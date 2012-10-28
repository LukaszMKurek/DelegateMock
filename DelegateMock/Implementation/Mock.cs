using System.Collections.ObjectModel;
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
         return Func(node.AsFunc());
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
      public IEnumerable<CallReport> GetCallReports(Delegate @delegate)
      {
         List<CallReport> list;
         if (_dic.TryGetValue(@delegate, out list))
            return list.AsReadOnly();

         return new List<CallReport>().AsReadOnly();
      }

      // na extension przerobiæ
      public void AssertThatWasCalled(CallOccurrenceBase call)
      {
         if (GetCallRaportsFilteredBy(call).Any() == false)
            throw new Exception("Funkcja nie by³a wo³ana");
      }

      private IEnumerable<CallReport> GetCallRaportsFilteredBy(CallOccurrenceBase call)
      {
         return call.GetCallRaport(GetCallReports(call.Delegate));
      }

      // na extension przerobiæ
      public void AssertThatWasCalledInOrder(params CallOccurrenceBase[] calls)
      {
         if (calls.Length == 0)
            throw new Exception("Z³e u¿ycie.");

         CallOccurrenceBase previousCall = calls.First();
         AssertThatWasCalled(previousCall);
         
         foreach (var call in calls.Skip(1))
         {
            AssertThatWasCalled(call);

            if (GetCallRaportsFilteredBy(previousCall).Single().Order + 1 != GetCallRaportsFilteredBy(call).Single().Order)
               throw new Exception("Kolejnoœæ nie zosta³a spe³niona");

            previousCall = call;
         }
      }
   }

   // todo to bêdzie u¿ywane do delegat nie generycznych
   public /*abstract*/ class CallOccurrenceBase
   {
      private readonly Delegate _delegate;
      protected readonly ReadOnlyCollection<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> _filters;

      protected CallOccurrenceBase(Delegate @delegate, ReadOnlyCollection<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters)
      {
         _delegate = @delegate;
         _filters = filters;
      }

      public Delegate Delegate
      {
         get { return _delegate; }
      }

      public IEnumerable<CallReport> GetCallRaport(IEnumerable<CallReport> callReports)
      {
         IEnumerable<CallReport> reports = _filters.Aggregate(callReports, (current, filter) => filter(current));

         return reports.OrderBy(x => x.Order).Take(1);
      }

      public CallOccurrenceBase AddFilter(Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         return new CallOccurrenceBase(
            Delegate,
            new List<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>(_filters) { filter }.AsReadOnly());
      }

      public static implicit operator CallOccurrenceBase(Delegate d)
      {
         return new CallOccurrenceBase(d, new List<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>().AsReadOnly());
      }
   }

   // todo rozró¿niaæ Action od func
   public sealed class CallOccurrence<TP1, TRet> : CallOccurrenceBase
   {
      private CallOccurrence(Delegate @delegate, ReadOnlyCollection<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>> filters) : base(@delegate, filters)
      {}

      public static implicit operator CallOccurrence<TP1, TRet>(Func<TP1, TRet> d)
      {
         return new CallOccurrence<TP1, TRet>(d, new List<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>().AsReadOnly());
      }
      
      public new CallOccurrence<TP1, TRet> AddFilter(Func<IEnumerable<CallReport>, IEnumerable<CallReport>> filter)
      {
         return new CallOccurrence<TP1, TRet>(
            Delegate, 
            new List<Func<IEnumerable<CallReport>, IEnumerable<CallReport>>>(_filters){ filter }.AsReadOnly());
      }
   }

   public static class CallOccurrenceExtension
   {
      public static CallOccurrence<TP1, TRet> WithArgs<TP1, TRet>(this Func<TP1, TRet> d, params object[] arguments)
      {
         return WithArgs((CallOccurrence<TP1, TRet>)d, arguments);
      }

      public static CallOccurrence<TP1, TRet> WithArgs<TP1, TRet>(this CallOccurrence<TP1, TRet> callOccurrence, params object[] arguments)
      {
         return callOccurrence.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }

      //-----------------------

      // todo not working with nullable types
      // delegaty nie generyczne nie bêd¹ typowane bo nie op³aca siê ich otaczaæ w statyczn¹ otoczkê
      public static CallOccurrence<TP1, TRet> WithArgs<TP1, TRet>(this Func<TP1, TRet> d, Func<TP1, bool> ds)
      {
         return WithArgs((CallOccurrence<TP1, TRet>)d, ds);
      }

      public static CallOccurrence<TP1, TRet> WithArgs<TP1, TRet>(this CallOccurrence<TP1, TRet> d, Func<TP1, bool> ds)
      {
         return d.AddFilter(reports => reports.Where(x => (bool)ds.DynamicInvoke(x.Arguments)));
      }

      //-----------------------

      public static CallOccurrence<TP1, TRet> SecondCall<TP1, TRet>(this Func<TP1, TRet> d)
      {
         return SecondCall((CallOccurrence<TP1, TRet>)d);
      }

      public static CallOccurrence<TP1, TRet> SecondCall<TP1, TRet>(this CallOccurrence<TP1, TRet> callOccurrence)
      {
         return callOccurrence.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static CallOccurrenceBase ThatThrows<TException>(this CallOccurrenceBase callOccurrence)
      {
         return callOccurrence.AddFilter(reports => reports.Where(x => x.Exception != null && x.Exception.GetType() == typeof(TException)));
      }

      public static CallOccurrence<TP1, TRet> ThatReturn<TP1, TRet>(this CallOccurrence<TP1, TRet> callOccurrence, TRet returnValue)
      {
         return callOccurrence.AddFilter(reports => reports.Where(x => x.ReturnValue.Equals(returnValue)));
      }
   }
}