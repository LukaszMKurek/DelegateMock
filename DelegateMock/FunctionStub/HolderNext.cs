
using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateMock.FunctionStub
{
   public sealed class HolderNext<TRet> : IHolderNext<TRet>
   {
      public HolderNext(Node<TRet> node, Func<bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TRet> _node;
      Node<TRet> IHolderNext<TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<bool> _filter;
      Func<bool> IHolderNext<TRet>.Filter
      {
         get { return _filter; }
      }
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

   public sealed class HolderNext<TP1, TP2, TRet> : IHolderNext<TP1, TP2, TRet>
   {
      public HolderNext(Node<TP1, TP2, TRet> node, Func<TP1, TP2, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TRet> _node;
      Node<TP1, TP2, TRet> IHolderNext<TP1, TP2, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, bool> _filter;
      Func<TP1, TP2, bool> IHolderNext<TP1, TP2, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TRet> : IHolderNext<TP1, TP2, TP3, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TRet> node, Func<TP1, TP2, TP3, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TRet> _node;
      Node<TP1, TP2, TP3, TRet> IHolderNext<TP1, TP2, TP3, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, bool> _filter;
      Func<TP1, TP2, TP3, bool> IHolderNext<TP1, TP2, TP3, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TRet> node, Func<TP1, TP2, TP3, TP4, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TRet> IHolderNext<TP1, TP2, TP3, TP4, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, bool> _filter;
      Func<TP1, TP2, TP3, TP4, bool> IHolderNext<TP1, TP2, TP3, TP4, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> : IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>
   {
      public HolderNext(Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> node, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> filter)
      {
         _node = node;
         _filter = filter;
      }

      private readonly Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> _node;
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>.Node
      {
         get { return _node; }
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>.Filter
      {
         get { return _filter; }
      }
   }

}
