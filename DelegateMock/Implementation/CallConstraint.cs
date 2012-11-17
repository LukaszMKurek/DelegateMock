using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   // for non generic delegates
   public class CallConstraint
   {
      private readonly Delegate _delegate;
      private readonly ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> _filters;

      protected static ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> EmptyFilters
      {
         get
         {
            Contract.Ensures(Contract.Result<ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>>() != null);
            Contract.Ensures(Contract.Result<ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>>().Length == 0);
            //Contract.Ensures(Contract.ForAll(Contract.Result<ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>>(), filter => filter != null));

            var empty = ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>.Empty;

            Contract.Assume(empty.Length == 0);
            //Contract.Assume(Contract.ForAll(empty, filter => filter != null));

            return empty;
         }
      }

      public CallConstraint(Delegate @delegate, ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
      {
         if (@delegate == null)
            throw new ArgumentNullException("delegate");
         if (filters == null)
            throw new ArgumentNullException("filters");
         //Contract.Requires(filters.Length == 0 || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(Filters.SequenceEqual(filters));
         Contract.Ensures(Delegate == @delegate);

         _delegate = @delegate;
         _filters = filters;
         Contract.Assume(Filters.SequenceEqual(filters));
      }

      public Delegate Delegate // todo hide by explicit interface
      {
         get
         {
            Contract.Ensures(Contract.Result<Delegate>() != null);

            return _delegate;
         }
      }

      public ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> Filters
      {
         get
         {
            //Contract.Ensures(Contract.Result<ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>>().Length == 0 || Contract.ForAll(Contract.Result<ImmutableList<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>>(), filter => filter != null));
            var immutableList = _filters;
            //Contract.Assume(immutableList.Length == 0 || Contract.ForAll(immutableList, filter => filter != null));

            return immutableList;
         }
      }

      [Pure]
      public static implicit operator CallConstraint(Delegate @delegate)
      {
         if (@delegate == null)
            throw new ArgumentNullException("delegate");
         Contract.Ensures(Contract.Result<CallConstraint>() != null);
         Contract.Ensures(Contract.Result<CallConstraint>().Delegate == @delegate);

         return new CallConstraint(@delegate, EmptyFilters);
      }
   }
}