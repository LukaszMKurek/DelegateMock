using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using System;

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

      public Func<TP1, TRet> Func<TP1, TRet>(Func<TP1, TRet> func)
      {
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
         List<CallReport> list;
         if (_dic.TryGetValue(@delegate, out list) == false)
            _dic.Add(@delegate, new List<CallReport> { callReport });
         else
            list.Add(callReport);
      }

      //mo¿e linked list? // przerobiæ na kontunuacje
      public ReadOnlyCollection<CallReport> GetCallReports(Delegate @delegate)
      {
         //return _dic[@delegate].ToList().AsReadOnly();
         List<CallReport> list;
         if (_dic.TryGetValue(@delegate, out list))
            return list.AsReadOnly();

         return new List<CallReport>().AsReadOnly();
      }
      /*
      // na extension przerobiæ
      public bool WasCalled(Delegate @delegate)
      {
         return _dic.ContainsKey(@delegate);
      }*/

      // na extension przerobiæ
      public void AssertThatWasCalled(CallOccurrence call)
      {
         CallReport callReport;
         if (call.TryGetCallRaport(GetCallReports(call.Delegate), out callReport) == false)
            throw new Exception("Funkcja nie by³a wo³ana");
      }

      // na extension przerobiæ
      public void AssertThatWasCalledInOrder(params CallOccurrence[] calls)
      {
         //calls.Lenght != 0
         CallOccurrence previousCall = calls.First();
         AssertThatWasCalled(previousCall);
         
         foreach (var call in calls.Skip(1))
         {
            AssertThatWasCalled(call);

            ReadOnlyCollection<CallReport> previous = GetCallReports(previousCall.Delegate);
            ReadOnlyCollection<CallReport> current = GetCallReports(call.Delegate);

            if (previousCall.GetCallRaport(previous).Order > call.GetCallRaport(current).Order)
               throw new Exception("Kolejnoœæ nie zosta³a spe³niona");

            previousCall = call;
         }
      }
   }

   public sealed class CallOccurrence
   {
      private readonly Delegate _delegate;
      private readonly ReadOnlyCollection<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> _filters; 

      private CallOccurrence(Delegate @delegate, ReadOnlyCollection<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
      {
         _delegate = @delegate;
         _filters = filters;
      }

      public Delegate Delegate
      {
         get { return _delegate; }
      }

      public static implicit operator CallOccurrence(Delegate d)
      {
         return new CallOccurrence(d, new List<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>().AsReadOnly());
      }

      public bool TryGetCallRaport(IEnumerable<CallReport> callReports, out CallReport callReport)
      {
         IEnumerable<CallReport> reports = _filters.Aggregate(callReports, (current, filter) => filter(current));

         foreach (var report in reports.OrderBy(x => x.Order))
         {
            callReport = report;
            return true;
         }

         callReport = default(CallReport);
         return false;
      }

      public CallReport GetCallRaport(IEnumerable<CallReport> callReports)
      {
         IEnumerable<CallReport> reports = _filters.Aggregate(callReports, (current, filter) => filter(current));

         return reports.OrderBy(x => x.Order).First();
      }

      public CallOccurrence AddFilter(Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         return new CallOccurrence(
            _delegate, 
            new List<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>(_filters){ filter }.AsReadOnly());
      }
   }

   public static class CallOccurrenceExtension
   {
      public static CallOccurrence WithArgs(this Delegate d, params object[] arguments)
      {
         return WithArgs((CallOccurrence)d, arguments);
      }

      public static CallOccurrence WithArgs(this CallOccurrence callOccurrence, params object[] arguments)
      {
         return callOccurrence.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
   }
}