using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateMock.FunctionStub
{/*
   // ReSharper disable TypeParameterCanBeVariant
   public interface IHolderFirst<TP1>
   {
      Func<TP1, bool> Filter { get; }
   }
   // ReSharper restore TypeParameterCanBeVariant

   public sealed class HolderFirst<TP1> : IHolderFirst<TP1>
   {
      public HolderFirst(Func<TP1, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, bool> _filter;
      Func<TP1, bool> IHolderFirst<TP1>.Filter
      {
         get { return _filter; }
      }
   }

   public interface IHolderNext<TP1, TRet>
   {
      Node<TP1, TRet> Node { get; }
      Func<TP1, bool> Filter { get; }
   }

   public sealed class HolderNext<TP1, TRet> : IHolderNext<TP1, TRet>
   {
      public HolderNext(Node<TP1, TRet> node, Func<TP1, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TRet> _node;
      Node<TP1, TRet> IHolderNext<TP1, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, bool> _filter;
      Func<TP1, bool> IHolderNext<TP1, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public interface INode<TP1, TRet>
   {
      Node<TP1, TRet> Previous { get; }
      Func<TP1, bool> Filter { get; }
      Func<TP1, TRet> ResultBuilder { get; }
   }

   public sealed class Node<TP1, TRet> : INode<TP1, TRet>
   {
      public Node(Node<TP1, TRet> previous, Func<TP1, bool> filter, Func<TP1, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TRet> _previous;
      Node<TP1, TRet> INode<TP1, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, bool> _filter;
      Func<TP1, bool> INode<TP1, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TRet> _resultBuilder;
      Func<TP1, TRet> INode<TP1, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TRet> Empty = null;

      //public static implicit operator Func<TP1, TRet>(Node<TP1, TRet> node)
      //{
      //   return node.AsFunc();
      //}

      public Func<TP1, TRet> AsFunc()
      {
         return p1 =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TRet> node, TP1 p1, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, out returnValue))
            return true;

         if (node.Filter(p1))
         {
            returnValue = node.ResultBuilder(p1);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public static class For
   {
      public static HolderFirst<TP1> Args<TP1>()
      {
         return new HolderFirst<TP1>(filter: p1 => true);
      }

      public static HolderFirst<TP1> Args<TP1>(Func<TP1, bool> filter)
      {
         return new HolderFirst<TP1>(filter: filter);
      }

      public static HolderFirst<TP1> Args<TP1>(TP1 a1)
      {
         return new HolderFirst<TP1>(filter: p1 => p1.Equals(a1));
      }

      //-----
      public static Node<TP1, TRet> Return<TP1, TRet>(this IHolderFirst<TP1> holder, TRet returnValue)
      {
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: p1 => returnValue, previous: Node<TP1, TRet>.Empty);
      }

      public static Node<TP1, TRet> Return<TP1, TRet>(this IHolderNext<TP1, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: p1 => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TRet> Call<TP1, TRet>(this IHolderNext<TP1, TRet> holder, Func<TP1, TRet> action)
      {
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TRet> ReturnSequence<TP1, TRet>(this IHolderFirst<TP1> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: p1 => sequence.GetNext(), previous: Node<TP1, TRet>.Empty);
      }

      public static Node<TP1, TRet> ReturnSequence<TP1, TRet>(this IHolderNext<TP1, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: p1 => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TRet> ForArgs<TP1, TRet>(this Node<TP1, TRet> node, Func<TP1, bool> filter)
      {
         return new HolderNext<TP1, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TRet> ForArgs<TP1, TRet>(this Node<TP1, TRet> node, TP1 a1)
      {
         return new HolderNext<TP1, TRet>(filter: p1 => p1.Equals(a1), node: node);
      }

      public static Node<TP1, TRet> ForRest<TP1, TRet>(this Node<TP1, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TRet>(filter: p1 => true, resultBuilder: p1 => returnValue, previous: node);
      }

      public static Node<TP1, TRet> ForRestCall<TP1, TRet>(this Node<TP1, TRet> node, Func<TP1, TRet> action)
      {
         return new Node<TP1, TRet>(filter: p1 => true, resultBuilder: action, previous: node);
      }
   }*/
}
