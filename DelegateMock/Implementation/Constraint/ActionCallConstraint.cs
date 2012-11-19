using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public sealed class ActionCallConstraint : CallConstraint
   {
      public ActionCallConstraint(Action action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action>() != null);

            return (Action)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint(Action func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1>>() != null);

            return (Action<TP1>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1>(Action<TP1> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2>>() != null);

            return (Action<TP1, TP2>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2>(Action<TP1, TP2> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3>>() != null);

            return (Action<TP1, TP2, TP3>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3>(Action<TP1, TP2, TP3> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4>>() != null);

            return (Action<TP1, TP2, TP3, TP4>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4>(Action<TP1, TP2, TP3, TP4> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5>(Action<TP1, TP2, TP3, TP4, TP5> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6>(Action<TP1, TP2, TP3, TP4, TP5, TP6> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(func, EmptyFilters);
      }
   }

   public sealed class ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> : CallConstraint
   {
      public ActionCallConstraint(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> action, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(action, filters)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == action);
      }

      public new Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>>() != null);

            return (Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>)base.Delegate;
         }
      }

      [Pure]
      public static implicit operator ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(func, EmptyFilters);
      }
   }

}
