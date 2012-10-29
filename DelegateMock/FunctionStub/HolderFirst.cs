
using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateMock.FunctionStub
{
   public sealed class HolderFirst : IHolderFirst
   {
      public HolderFirst(Func<bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<bool> _filter;
      Func<bool> IHolderFirst.Filter
      {
         get { return _filter; }
      }
   }

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

   public sealed class HolderFirst<TP1, TP2> : IHolderFirst<TP1, TP2>
   {
      public HolderFirst(Func<TP1, TP2, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, bool> _filter;
      Func<TP1, TP2, bool> IHolderFirst<TP1, TP2>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3> : IHolderFirst<TP1, TP2, TP3>
   {
      public HolderFirst(Func<TP1, TP2, TP3, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, bool> _filter;
      Func<TP1, TP2, TP3, bool> IHolderFirst<TP1, TP2, TP3>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4> : IHolderFirst<TP1, TP2, TP3, TP4>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, bool> _filter;
      Func<TP1, TP2, TP3, TP4, bool> IHolderFirst<TP1, TP2, TP3, TP4>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5> : IHolderFirst<TP1, TP2, TP3, TP4, TP5>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>.Filter
      {
         get { return _filter; }
      }
   }

   public sealed class HolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> : IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>
   {
      public HolderFirst(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> filter)
      {
         _filter = filter;
      }

      private readonly Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> _filter;
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>.Filter
      {
         get { return _filter; }
      }
   }

}
