
using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateMock.FunctionStub
{
   public sealed class Node<TRet> : INode<TRet>
   {
      public Node(Node<TRet> previous, Func<bool> filter, Func<TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TRet> _previous;
      Node<TRet> INode<TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<bool> _filter;
      Func<bool> INode<TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TRet> _resultBuilder;
      Func<TRet> INode<TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TRet> Empty = null;

      public Func<TRet> AsFunc()
      {
         return () =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TRet> node, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, out returnValue))
            return true;

         if (node.Filter())
         {
            returnValue = node.ResultBuilder();
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
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

      public Func<TP1, TRet> AsFunc()
      {
         return (p1) =>
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

   public sealed class Node<TP1, TP2, TRet> : INode<TP1, TP2, TRet>
   {
      public Node(Node<TP1, TP2, TRet> previous, Func<TP1, TP2, bool> filter, Func<TP1, TP2, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TRet> _previous;
      Node<TP1, TP2, TRet> INode<TP1, TP2, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, bool> _filter;
      Func<TP1, TP2, bool> INode<TP1, TP2, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TRet> _resultBuilder;
      Func<TP1, TP2, TRet> INode<TP1, TP2, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TRet> Empty = null;

      public Func<TP1, TP2, TRet> AsFunc()
      {
         return (p1, p2) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TRet> node, TP1 p1, TP2 p2, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, out returnValue))
            return true;

         if (node.Filter(p1, p2))
         {
            returnValue = node.ResultBuilder(p1, p2);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TRet> : INode<TP1, TP2, TP3, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TRet> previous, Func<TP1, TP2, TP3, bool> filter, Func<TP1, TP2, TP3, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TRet> _previous;
      Node<TP1, TP2, TP3, TRet> INode<TP1, TP2, TP3, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, bool> _filter;
      Func<TP1, TP2, TP3, bool> INode<TP1, TP2, TP3, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TRet> INode<TP1, TP2, TP3, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TRet> AsFunc()
      {
         return (p1, p2, p3) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TRet> node, TP1 p1, TP2 p2, TP3 p3, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3))
         {
            returnValue = node.ResultBuilder(p1, p2, p3);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TRet> : INode<TP1, TP2, TP3, TP4, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TRet> previous, Func<TP1, TP2, TP3, TP4, bool> filter, Func<TP1, TP2, TP3, TP4, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TRet> INode<TP1, TP2, TP3, TP4, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, bool> _filter;
      Func<TP1, TP2, TP3, TP4, bool> INode<TP1, TP2, TP3, TP4, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TRet> INode<TP1, TP2, TP3, TP4, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TRet> AsFunc()
      {
         return (p1, p2, p3, p4) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TRet> INode<TP1, TP2, TP3, TP4, TP5, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, bool> INode<TP1, TP2, TP3, TP4, TP5, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TRet> INode<TP1, TP2, TP3, TP4, TP5, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7, p8) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, p8, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, TP8 p8, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, p8, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7, p8))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7, p8);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, p8, p9, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, TP8 p8, TP9 p9, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, p8, p9, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7, p8, p9))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, TP8 p8, TP9 p9, TP10 p10, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, TP8 p8, TP9 p9, TP10 p10, TP11 p11, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, TP8 p8, TP9 p9, TP10 p10, TP11 p11, TP12 p12, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, TP8 p8, TP9 p9, TP10 p10, TP11 p11, TP12 p12, TP13 p13, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, TP8 p8, TP9 p9, TP10 p10, TP11 p11, TP12 p12, TP13 p13, TP14 p14, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, TP8 p8, TP9 p9, TP10 p10, TP11 p11, TP12 p12, TP13 p13, TP14 p14, TP15 p15, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public sealed class Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> : INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>
   {
      public Node(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> previous, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> filter, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> resultBuilder)
      {
         _previous = previous;
         _filter = filter;
         _resultBuilder = resultBuilder;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> _previous;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>.Previous
      {
         get { return _previous; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>.Filter
      {
         get { return _filter; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> _resultBuilder;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>.ResultBuilder
      {
         get { return _resultBuilder; }
      }

      public static Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Empty = null;

      public Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> AsFunc()
      {
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, out returnValue))
               return returnValue;

            throw new Exception("No result to return.");
         };
      }

      private static bool TryGetReturnValue(INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> node, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, TP6 p6, TP7 p7, TP8 p8, TP9 p9, TP10 p10, TP11 p11, TP12 p12, TP13 p13, TP14 p14, TP15 p15, TP16 p16, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, out returnValue))
            return true;

         if (node.Filter(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16))
         {
            returnValue = node.ResultBuilder(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

}
