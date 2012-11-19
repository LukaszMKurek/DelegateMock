using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public sealed class FuncCallConstraint<TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TRet>>() != null);

            return (Func<TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TRet>(Func<TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TRet>>() != null);

            return (Func<TP1, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TRet>(Func<TP1, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TRet>>() != null);

            return (Func<TP1, TP2, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TRet>(Func<TP1, TP2, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TRet>(Func<TP1, TP2, TP3, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TRet>(Func<TP1, TP2, TP3, TP4, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(func, EmptyFilters);
      }
   }
   
   public sealed class FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> : CallConstraint
   {
      public FuncCallConstraint(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> function, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(function, filters)
      {
         if (function == null)
            throw new ArgumentNullException("function");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == function);
      }

      public new Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>>() != null);

            return (Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(func, EmptyFilters);
      }
   }
   
}
