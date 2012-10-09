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
         List<CallReport> list;
         if (_dic.TryGetValue(@delegate, out list))
            return list.AsReadOnly();

         return new List<CallReport>().AsReadOnly();
      }

      // na extension przerobiæ
      public void AssertThatWasCalled(CallOccurrence call)
      {
         if (GetCallRaportsFilteredBy(call).Any() == false)
            throw new Exception("Funkcja nie by³a wo³ana");
      }

      private IEnumerable<CallReport> GetCallRaportsFilteredBy(CallOccurrence call)
      {
         return call.GetCallRaport(GetCallReports(call.Delegate));
      }

      // na extension przerobiæ
      public void AssertThatWasCalledInOrder(params CallOccurrence[] calls)
      {
         if (calls.Length == 0)
            throw new Exception("Z³e u¿ycie.");

         CallOccurrence previousCall = calls.First();
         AssertThatWasCalled(previousCall);
         
         foreach (var call in calls.Skip(1))
         {
            AssertThatWasCalled(call);

            if (GetCallRaportsFilteredBy(previousCall).Single().Order > GetCallRaportsFilteredBy(call).Single().Order)
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

      public IEnumerable<CallReport> GetCallRaport(IEnumerable<CallReport> callReports)
      {
         IEnumerable<CallReport> reports = _filters.Aggregate(callReports, (current, filter) => filter(current));

         return reports.OrderBy(x => x.Order).Take(1);
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