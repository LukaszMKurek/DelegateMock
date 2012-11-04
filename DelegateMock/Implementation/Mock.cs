using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;
using DelegateMock.FunctionStub;

namespace DelegateMock.Implementation
{
   public sealed class Mock
   {
      private readonly Dictionary<Delegate, List<CallReport>> _dic =
         new Dictionary<Delegate, List<CallReport>>();

      private int _n;

      private Mock()
      { }

      public static Mock New
      {
         get { return new Mock(); }
      }

      public Func<TP1, TRet> Func<TP1, TRet>(Node<TP1, TRet> node)
      {
         Contract.Requires(node != null);

         return Func(node.AsFunc());
      }

      public Func<TP1, TRet> Func<TP1, TRet>(Func<TP1, TRet> func)
      {
         Contract.Requires(func != null);

         Func<TP1, TRet> wrapDelegateTemp = null;
         Func<TP1, TRet> wrapDelegate = p1 =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
// ReSharper disable AccessToModifiedClosure
               AddCallReport(wrapDelegateTemp, new CallReport(new object[] { p1 }, returnValue, exception, _n++));
// ReSharper restore AccessToModifiedClosure
            }
         };
         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      private void AddCallReport(Delegate @delegate, CallReport callReport)
      {
         Contract.Requires(@delegate != null);

         List<CallReport> list;
         if (_dic.TryGetValue(@delegate, out list) == false)
            _dic.Add(@delegate, new List<CallReport> { callReport });
         else
            list.Add(callReport);
      }

      //mo¿e linked list? // przerobiæ na kontunuacje
      public List<CallReport> GetCallReports(Delegate @delegate)
      {
         Contract.Requires(@delegate != null);

         List<CallReport> list;
         if (_dic.TryGetValue(@delegate, out list))
         {
            Contract.Assume(list != null); //todo
            return list.ToList();
         }

         return new List<CallReport>();
      }

      // na extension przerobiæ
      public void AssertThatWasCalled(CallOccurrenceBase call)
      {
         Contract.Requires(call != null);

         if (GetCallRaportsFilteredBy(call).Count == 0)
            throw new Exception("Funkcja nie by³a wo³ana");
      }

      private List<CallReport> GetCallRaportsFilteredBy(CallOccurrenceBase call)
      {
         return call.GetCallRaport(GetCallReports(call.Delegate));
      }

      private CallReport GetSingleCallReport(CallOccurrenceBase call)
      {
         List<CallReport> callRaports = GetCallRaportsFilteredBy(call);
         if (callRaports.Count == 0) // todo eby wyj¹tek by³ wyra¿ny wyprowadzic go delegat¹ mo¿e
            throw new Exception("Funkcja nie by³a wo³ana");

         return callRaports[0];
      }

      // na extension przerobiæ
      public void AssertThatWasCalledInOrder(params CallOccurrenceBase[] calls)
      {
         Contract.Requires(calls != null && calls.Length > 0 && Contract.ForAll(calls, call => call != null));

         if (calls.Length == 0)
            throw new Exception("Z³e u¿ycie.");

         CallOccurrenceBase previousCall = calls[0];
         int previousOrder = GetSingleCallReport(previousCall).Order;
         
         foreach (var call in calls.Skip(1))
         {
            Contract.Assume(call != null); // todo
            //AssertThatWasCalled(call);

            int currentOrder = GetSingleCallReport(call).Order;
            if (previousOrder + 1 != currentOrder)
               throw new Exception("Kolejnoœæ nie zosta³a spe³niona");

            previousOrder = currentOrder;
         }
      }
   }

   // todo to bêdzie u¿ywane do delegat nie generycznych
   public /*abstract*/ class CallOccurrenceBase
   {
      private readonly Delegate _delegate;
      protected readonly ReadOnlyCollection<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> _filters;
      protected static readonly ReadOnlyCollection<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> EmptyFilters;
      static CallOccurrenceBase()
      {
         Contract.Ensures(EmptyFilters != null);
         Contract.Ensures(EmptyFilters.Count == 0);
         Contract.Ensures(Contract.ForAll(EmptyFilters, filter => filter != null));

         EmptyFilters = new List<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>(0).AsReadOnly();
         
         Contract.Assume(EmptyFilters.Count == 0);
         Contract.Assume(Contract.ForAll(EmptyFilters, filter => filter != null));
      }

      protected CallOccurrenceBase(Delegate @delegate, IEnumerable<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
      {
         Contract.Requires(@delegate != null);
         Contract.Requires(filters != null);
         Contract.Requires(filters.Any() == false || Contract.ForAll(filters, filter => filter != null));

         _delegate = @delegate;
         _filters = filters.ToList().AsReadOnly();
         Contract.Assume(_filters.Count == 0 || Contract.ForAll(_filters, filter => filter != null));
         Contract.Assume(EmptyFilters.Count == 0);
         Contract.Assume(Contract.ForAll(EmptyFilters, filter => filter != null));
      }

      [ContractInvariantMethod]
      private void ObjectInvariant()
      {
         Contract.Invariant(_delegate != null);
         Contract.Invariant(_filters != null);
         Contract.Invariant(_filters.Count == 0 || Contract.ForAll(_filters, filter => filter != null));
         Contract.Invariant(EmptyFilters != null);
         Contract.Invariant(EmptyFilters.Count == 0 || Contract.ForAll(EmptyFilters, filter => filter != null));
      }

      public Delegate Delegate
      {
         get { return _delegate; }
      }

      [Pure]
      public List<CallReport> GetCallRaport(IEnumerable<CallReport> callReports)
      {
         Contract.Requires(callReports != null);
         //Contract.Requires(Contract.ForAll(callReports, callReport => callReport != null));
         //Contract.Ensures(Contract.Result<List<CallReport>>() != null && Contract.Result<List<CallReport>>().Count <= 1); //todo
         // todo okreœliæ ¿e lista jest posortowana

         IEnumerable<CallReport> reports = _filters.Aggregate(callReports, (current, filter) => filter(current));
         Contract.Assume(reports != null); //todo bo filter mo¿e zwróciæ null
         return reports.OrderBy(x => x.Order).Take(1).ToList();
      }

      [Pure]
      public CallOccurrenceBase AddFilter(Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         Contract.Requires(filter != null);
         Contract.Assert(_filters.Count == 0 || Contract.ForAll(_filters, f => f != null));
         Contract.Assert(EmptyFilters.Count == 0 || Contract.ForAll(EmptyFilters, f => f != null));
         var filters = _filters.ToList();
         filters.Add(filter);

         return new CallOccurrenceBase(Delegate, filters);
      }

      [Pure]
      public static implicit operator CallOccurrenceBase(Delegate d)
      {
         Contract.Requires(d != null);
         Contract.Assert(EmptyFilters.Count == 0 || Contract.ForAll(EmptyFilters, filter => filter != null));

         return new CallOccurrenceBase(d, EmptyFilters);
      }
   }

   // todo rozró¿niaæ Action od func
   public sealed class CallOccurrence<TP1, TRet> : CallOccurrenceBase
   {
      private CallOccurrence(Delegate @delegate, IEnumerable<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
         : base(@delegate, filters)
      {
         Contract.Requires(@delegate != null);
         Contract.Requires(filters != null);
         Contract.Requires(filters.Any() == false || Contract.ForAll(filters, filter => filter != null));
         Contract.Ensures(_filters.Count == 0 || Contract.ForAll(_filters, filter => filter != null));
      }

      [Pure]
      public static implicit operator CallOccurrence<TP1, TRet>(Func<TP1, TRet> d)
      {
         Contract.Requires(d != null);

         return new CallOccurrence<TP1, TRet>(d, EmptyFilters);
      }

      [Pure]
      public new CallOccurrence<TP1, TRet> AddFilter(Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         Contract.Requires(filter != null);

         var filters = _filters.ToList();
         filters.Add(filter);
         //Contract.Assume(filters != null && Contract.ForAll(filters, f => f != null)); // todo
         return new CallOccurrence<TP1, TRet>(Delegate, filters);
      }
   }

   public static class CallOccurrenceExtension
   {
      public static CallOccurrence<TP1, TRet> WithArgs<TP1, TRet>(this Func<TP1, TRet> d, params object[] arguments)
      {
         Contract.Requires(d != null);
         Contract.Requires(arguments != null);

         return WithArgs((CallOccurrence<TP1, TRet>)d, arguments);
      }

      public static CallOccurrence<TP1, TRet> WithArgs<TP1, TRet>(this CallOccurrence<TP1, TRet> callOccurrence, params object[] arguments)
      {
         Contract.Requires(callOccurrence != null);
         Contract.Requires(arguments != null);

         return callOccurrence.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }

      //-----------------------

      // todo not working with nullable types
      // delegaty nie generyczne nie bêd¹ typowane bo nie op³aca siê ich otaczaæ w statyczn¹ otoczkê
      public static CallOccurrence<TP1, TRet> WithArgs<TP1, TRet>(this Func<TP1, TRet> d, Func<TP1, bool> ds)
      {
         Contract.Requires(d != null);
         Contract.Requires(ds != null);

         return WithArgs((CallOccurrence<TP1, TRet>)d, ds);
      }

      public static CallOccurrence<TP1, TRet> WithArgs<TP1, TRet>(this CallOccurrence<TP1, TRet> d, Func<TP1, bool> ds)
      {
         Contract.Requires(d != null);
         Contract.Requires(ds != null);

         return d.AddFilter(reports => reports.Where(x => (bool)ds.DynamicInvoke(x.Arguments)));
      }

      //-----------------------

      public static CallOccurrence<TP1, TRet> SecondCall<TP1, TRet>(this Func<TP1, TRet> d)
      {
         Contract.Requires(d != null);

         return SecondCall((CallOccurrence<TP1, TRet>)d);
      }

      public static CallOccurrence<TP1, TRet> SecondCall<TP1, TRet>(this CallOccurrence<TP1, TRet> callOccurrence)
      {
         Contract.Requires(callOccurrence != null);

         return callOccurrence.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static CallOccurrenceBase ThatThrows<TException>(this CallOccurrenceBase callOccurrence)
      {
         Contract.Requires(callOccurrence != null);

         return callOccurrence.AddFilter(reports => reports.Where(x => x.Exception != null && x.Exception.GetType() == typeof(TException)));
      }

      public static CallOccurrence<TP1, TRet> ThatReturn<TP1, TRet>(this CallOccurrence<TP1, TRet> callOccurrence, TRet returnValue)
      {
         Contract.Requires(callOccurrence != null);

         return callOccurrence.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
   }
}