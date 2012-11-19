using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public static class CallConstraintExtension // todo  explicit interface
   {
      [Pure]
      public static List<CallReport> FilterCallRaport(this CallConstraint self, IEnumerable<CallReport> callReports)
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
      public static CallConstraint AddFilter(this CallConstraint self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");
         Contract.Ensures(Contract.Result<CallConstraint>() != null);
         
         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && Contract.ForAll(filters, f => f != null));
         
         return new CallConstraint(self.Delegate, filters);
      }
      //------------------------------------------

      [Pure]
      public static FuncCallConstraint<TRet> AddFilter<TRet>(this FuncCallConstraint<TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint AddFilter(this ActionCallConstraint self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TRet> AddFilter<TP1, TRet>(this FuncCallConstraint<TP1, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1> AddFilter<TP1>(this ActionCallConstraint<TP1> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TRet> AddFilter<TP1, TP2, TRet>(this FuncCallConstraint<TP1, TP2, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2> AddFilter<TP1, TP2>(this ActionCallConstraint<TP1, TP2> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TRet> AddFilter<TP1, TP2, TP3, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3> AddFilter<TP1, TP2, TP3>(this ActionCallConstraint<TP1, TP2, TP3> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> AddFilter<TP1, TP2, TP3, TP4, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4> AddFilter<TP1, TP2, TP3, TP4>(this ActionCallConstraint<TP1, TP2, TP3, TP4> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> AddFilter<TP1, TP2, TP3, TP4, TP5>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(self.Delegate, filters);
      }
      //--------------------------------------------

      [Pure]
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(self.Delegate, filters);
      }

      [Pure]
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> AddFilter<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> self, Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         if (self == null)
            throw new ArgumentNullException("self");
         if (filter == null)
            throw new ArgumentNullException("filter");

         var filters = self.Filters.Add(filter);
         Contract.Assume(filters.Length > 0 && filters.All(f => f != null));

         return new ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(self.Delegate, filters);
      }
      //--------------------------------------------

   }
}
