
using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateMock.FunctionStub
{
   public static class For
   {
      public static HolderFirst<TP1> Args<TP1>()
      {
         return new HolderFirst<TP1>(filter: (p1) => true);
      }
      
      public static HolderFirst<TP1> Args<TP1>(Func<TP1, bool> filter)
      {
         return new HolderFirst<TP1>(filter: filter);
      }

      public static HolderFirst<TP1> Args<TP1>(TP1 a1)
      {
         return new HolderFirst<TP1>(filter: (p1) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TRet> Return<TP1, TRet>(this IHolderFirst<TP1> holder, TRet returnValue)
      {
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: (p1) => returnValue, previous: Node<TP1, TRet>.Empty);
      }

      public static Node<TP1, TRet> Return<TP1, TRet>(this IHolderNext<TP1, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: (p1) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TRet> Call<TP1, TRet>(this IHolderNext<TP1, TRet> holder, Func<TP1, TRet> action)
      {
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TRet> ReturnSequence<TP1, TRet>(this IHolderFirst<TP1> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: (p1) => sequence.GetNext(), previous: Node<TP1, TRet>.Empty);
      }

      public static Node<TP1, TRet> ReturnSequence<TP1, TRet>(this IHolderNext<TP1, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TRet>(filter: holder.Filter, resultBuilder: (p1) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TRet> ForArgs<TP1, TRet>(this Node<TP1, TRet> node, Func<TP1, bool> filter)
      {
         return new HolderNext<TP1, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TRet> ForArgs<TP1, TRet>(this Node<TP1, TRet> node, TP1 a1)
      {
         return new HolderNext<TP1, TRet>(filter: (p1) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TRet> ForRest<TP1, TRet>(this Node<TP1, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TRet>(filter: (p1) => true, resultBuilder: (p1) => returnValue, previous: node);
      }

      public static Node<TP1, TRet> ForRestCall<TP1, TRet>(this Node<TP1, TRet> node, Func<TP1, TRet> action)
      {
         return new Node<TP1, TRet>(filter: (p1) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2> Args<TP1, TP2>()
      {
         return new HolderFirst<TP1, TP2>(filter: (p1, p2) => true);
      }
      
      public static HolderFirst<TP1, TP2> Args<TP1, TP2>(Func<TP1, TP2, bool> filter)
      {
         return new HolderFirst<TP1, TP2>(filter: filter);
      }

      public static HolderFirst<TP1, TP2> Args<TP1, TP2>(TP1 a1, TP2 a2)
      {
         return new HolderFirst<TP1, TP2>(filter: (p1, p2) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TRet> Return<TP1, TP2, TRet>(this IHolderFirst<TP1, TP2> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TRet>(filter: holder.Filter, resultBuilder: (p1, p2) => returnValue, previous: Node<TP1, TP2, TRet>.Empty);
      }

      public static Node<TP1, TP2, TRet> Return<TP1, TP2, TRet>(this IHolderNext<TP1, TP2, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TRet>(filter: holder.Filter, resultBuilder: (p1, p2) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TRet> Call<TP1, TP2, TRet>(this IHolderNext<TP1, TP2, TRet> holder, Func<TP1, TP2, TRet> action)
      {
         return new Node<TP1, TP2, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TRet> ReturnSequence<TP1, TP2, TRet>(this IHolderFirst<TP1, TP2> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TRet>(filter: holder.Filter, resultBuilder: (p1, p2) => sequence.GetNext(), previous: Node<TP1, TP2, TRet>.Empty);
      }

      public static Node<TP1, TP2, TRet> ReturnSequence<TP1, TP2, TRet>(this IHolderNext<TP1, TP2, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TRet>(filter: holder.Filter, resultBuilder: (p1, p2) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TRet> ForArgs<TP1, TP2, TRet>(this Node<TP1, TP2, TRet> node, Func<TP1, TP2, bool> filter)
      {
         return new HolderNext<TP1, TP2, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TRet> ForArgs<TP1, TP2, TRet>(this Node<TP1, TP2, TRet> node, TP1 a1, TP2 a2)
      {
         return new HolderNext<TP1, TP2, TRet>(filter: (p1, p2) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TRet> ForRest<TP1, TP2, TRet>(this Node<TP1, TP2, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TRet>(filter: (p1, p2) => true, resultBuilder: (p1, p2) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TRet> ForRestCall<TP1, TP2, TRet>(this Node<TP1, TP2, TRet> node, Func<TP1, TP2, TRet> action)
      {
         return new Node<TP1, TP2, TRet>(filter: (p1, p2) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3> Args<TP1, TP2, TP3>()
      {
         return new HolderFirst<TP1, TP2, TP3>(filter: (p1, p2, p3) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3> Args<TP1, TP2, TP3>(Func<TP1, TP2, TP3, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3> Args<TP1, TP2, TP3>(TP1 a1, TP2 a2, TP3 a3)
      {
         return new HolderFirst<TP1, TP2, TP3>(filter: (p1, p2, p3) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TRet> Return<TP1, TP2, TP3, TRet>(this IHolderFirst<TP1, TP2, TP3> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3) => returnValue, previous: Node<TP1, TP2, TP3, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TRet> Return<TP1, TP2, TP3, TRet>(this IHolderNext<TP1, TP2, TP3, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TRet> Call<TP1, TP2, TP3, TRet>(this IHolderNext<TP1, TP2, TP3, TRet> holder, Func<TP1, TP2, TP3, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TRet> ReturnSequence<TP1, TP2, TP3, TRet>(this IHolderFirst<TP1, TP2, TP3> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TRet> ReturnSequence<TP1, TP2, TP3, TRet>(this IHolderNext<TP1, TP2, TP3, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TRet> ForArgs<TP1, TP2, TP3, TRet>(this Node<TP1, TP2, TP3, TRet> node, Func<TP1, TP2, TP3, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TRet> ForArgs<TP1, TP2, TP3, TRet>(this Node<TP1, TP2, TP3, TRet> node, TP1 a1, TP2 a2, TP3 a3)
      {
         return new HolderNext<TP1, TP2, TP3, TRet>(filter: (p1, p2, p3) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TRet> ForRest<TP1, TP2, TP3, TRet>(this Node<TP1, TP2, TP3, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TRet>(filter: (p1, p2, p3) => true, resultBuilder: (p1, p2, p3) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TRet> ForRestCall<TP1, TP2, TP3, TRet>(this Node<TP1, TP2, TP3, TRet> node, Func<TP1, TP2, TP3, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TRet>(filter: (p1, p2, p3) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4> Args<TP1, TP2, TP3, TP4>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4>(filter: (p1, p2, p3, p4) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4> Args<TP1, TP2, TP3, TP4>(Func<TP1, TP2, TP3, TP4, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4> Args<TP1, TP2, TP3, TP4>(TP1 a1, TP2 a2, TP3 a3, TP4 a4)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4>(filter: (p1, p2, p3, p4) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TRet> Return<TP1, TP2, TP3, TP4, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TRet> Return<TP1, TP2, TP3, TP4, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TRet> Call<TP1, TP2, TP3, TP4, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TRet> holder, Func<TP1, TP2, TP3, TP4, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TRet> ForArgs<TP1, TP2, TP3, TP4, TRet>(this Node<TP1, TP2, TP3, TP4, TRet> node, Func<TP1, TP2, TP3, TP4, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TRet> ForArgs<TP1, TP2, TP3, TP4, TRet>(this Node<TP1, TP2, TP3, TP4, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TRet>(filter: (p1, p2, p3, p4) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TRet> ForRest<TP1, TP2, TP3, TP4, TRet>(this Node<TP1, TP2, TP3, TP4, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TRet>(filter: (p1, p2, p3, p4) => true, resultBuilder: (p1, p2, p3, p4) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TRet> ForRestCall<TP1, TP2, TP3, TP4, TRet>(this Node<TP1, TP2, TP3, TP4, TRet> node, Func<TP1, TP2, TP3, TP4, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TRet>(filter: (p1, p2, p3, p4) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5> Args<TP1, TP2, TP3, TP4, TP5>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5>(filter: (p1, p2, p3, p4, p5) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5> Args<TP1, TP2, TP3, TP4, TP5>(Func<TP1, TP2, TP3, TP4, TP5, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5> Args<TP1, TP2, TP3, TP4, TP5>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5>(filter: (p1, p2, p3, p4, p5) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TRet> Return<TP1, TP2, TP3, TP4, TP5, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TRet> Return<TP1, TP2, TP3, TP4, TP5, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TRet> Call<TP1, TP2, TP3, TP4, TP5, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TRet>(filter: (p1, p2, p3, p4, p5) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TRet>(filter: (p1, p2, p3, p4, p5) => true, resultBuilder: (p1, p2, p3, p4, p5) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TRet>(filter: (p1, p2, p3, p4, p5) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6> Args<TP1, TP2, TP3, TP4, TP5, TP6>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6>(filter: (p1, p2, p3, p4, p5, p6) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6> Args<TP1, TP2, TP3, TP4, TP5, TP6>(Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6> Args<TP1, TP2, TP3, TP4, TP5, TP6>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6>(filter: (p1, p2, p3, p4, p5, p6) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(filter: (p1, p2, p3, p4, p5, p6) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(filter: (p1, p2, p3, p4, p5, p6) => true, resultBuilder: (p1, p2, p3, p4, p5, p6) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(filter: (p1, p2, p3, p4, p5, p6) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(filter: (p1, p2, p3, p4, p5, p6, p7) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(filter: (p1, p2, p3, p4, p5, p6, p7) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(filter: (p1, p2, p3, p4, p5, p6, p7, p8) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(filter: (p1, p2, p3, p4, p5, p6, p7, p8) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12, TP13 a13)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12, TP13 a13)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12, TP13 a13, TP14 a14)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12, TP13 a13, TP14 a14)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12, TP13 a13, TP14 a14, TP15 a15)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12, TP13 a13, TP14 a14, TP15 a15)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>()
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => true);
      }
      
      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> filter)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(filter: filter);
      }

      public static HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> Args<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12, TP13 a13, TP14 a14, TP15 a15, TP16 a16)
      {
         return new HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }));
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => returnValue, previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Return<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => returnValue, previous: holder.Node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Call<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> holder, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(filter: holder.Filter, resultBuilder: action, previous: holder.Node);
      }

      //-----
      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => sequence.GetNext(), previous: Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>.Empty);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> ReturnSequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(filter: holder.Filter, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => sequence.GetNext(), previous: holder.Node);
      }

      //-----
      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> filter)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(filter: filter, node: node);
      }

      public static HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> ForArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> node, TP1 a1, TP2 a2, TP3 a3, TP4 a4, TP5 a5, TP6 a6, TP7 a7, TP8 a8, TP9 a9, TP10 a10, TP11 a11, TP12 a12, TP13 a13, TP14 a14, TP15 a15, TP16 a16)
      {
         return new HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => new object[]{ p1 }.SequenceEqual(new object[]{ a1 }), node: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> ForRest<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => true, resultBuilder: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => returnValue, previous: node);
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> ForRestCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> action)
      {
         return new Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(filter: (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => true, resultBuilder: action, previous: node);
      }
      //*******************************************************************************************************************************************************************************************************************************************************

   }
}
