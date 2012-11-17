using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
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
}