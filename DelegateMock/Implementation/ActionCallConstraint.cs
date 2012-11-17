using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
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
}