using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public static class CallAssertExtension // todo  explicit interface
   {
      [Pure]
      public static List<CallReport> FilterCallRaport(this CallAssert self, IEnumerable<CallReport> callReports)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (callReports == null)
            throw new ArgumentNullException("callReports");
         Contract.Ensures(Contract.Result<List<CallReport>>() != null);
         Contract.Ensures(Contract.Result<List<CallReport>>().Count <= 1);

         IEnumerable<CallReport> reports = self.Filters.Aggregate(callReports, (current, filter) =>
         {
            IEnumerable<CallReport> filtered = filter(current);
            if (filtered == null)
               throw new Exception("filtr zwróci³ null a nie powinien");
            return filtered;
         });
         Contract.Assume(reports != null);
         List<CallReport> callRaport = reports.OrderBy(x => x.Order).Take(1).ToList();
         Contract.Assume(callRaport.Count <= 1);
         return callRaport;
      }

      [Pure]
      public static CallAssert AddFilter(this CallAssert self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");
         Contract.Ensures(Contract.Result<CallAssert>() != null);
         
         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && Contract.ForAll(filters, f => f != null));
         
         return new CallAssert(self.Delegate, filters);
      }

      [Pure]
      public static CallAssert<TP1, TRet> AddFilter<TP1, TRet>(this CallAssert<TP1, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new CallAssert<TP1, TRet>(self.Delegate, filters);
      }
   }
}