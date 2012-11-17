using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public sealed class Mock
   {
      private readonly Dictionary<Delegate, List<CallReport>> _dic =
         new Dictionary<Delegate, List<CallReport>>();

      private int _callNumber;

      private Mock()
      {}

      public static Mock New
      {
         get { return new Mock(); }
      }

      internal void ReportCall(Delegate @delegate, ImmutableArray<object> parameters, object returnValue, Exception exception) // todo explicit interface
      {
         if (@delegate == null)
            throw new ArgumentNullException("delegate");

         Contract.Assume(_callNumber >= 0);
         AddCallReport(@delegate, new CallReport(parameters, returnValue, exception, _callNumber++));
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
      private List<CallReport> GetCallReports(Delegate @delegate)
      {
         List<CallReport> list;
         if (_dic.TryGetValue(@delegate, out list))
         {
            Contract.Assume(list != null); //todo
            return list.ToList();
         }

         return new List<CallReport>();
      }

      // na extension przerobiæ
      public void AssertThatWasCalled(CallConstraint callConstraint)
      {
         if (callConstraint == null)
            throw new ArgumentNullException("callConstraint");

         if (GetCallRaportsFilteredBy(callConstraint).Count == 0)
            throw new Exception("Funkcja nie by³a wo³ana");
      }
      
      private List<CallReport> GetCallRaportsFilteredBy(CallConstraint callConstraint)
      {
         return callConstraint.FilterCallRaport(GetCallReports(callConstraint.Delegate));
      }

      private CallReport GetSingleCallReport(CallConstraint callConstraint)
      {
         List<CallReport> callRaports = GetCallRaportsFilteredBy(callConstraint);
         if (callRaports.Count == 0) // todo eby wyj¹tek by³ wyra¿ny wyprowadzic go delegat¹ mo¿e
            throw new Exception("Funkcja nie by³a wo³ana");

         return callRaports[0];
      }

      // na extension przerobiæ
      public void AssertThatWasCalledInOrder(params CallConstraint[] callConstraints)
      {
         if (callConstraints == null)
            throw new ArgumentNullException("callConstraints");
         if (callConstraints.Length == 0)
            throw new Exception("Z³e u¿ycie.");
         Contract.Requires(Contract.ForAll(callConstraints, call => call != null));

         CallConstraint previousCall = callConstraints[0];
         int previousOrder = GetSingleCallReport(previousCall).Order;
         
         foreach (var callConstraint in callConstraints.Skip(1))
         {
            Contract.Assume(callConstraint != null); // todo
            //AssertThatWasCalled(CallConstraint);

            int currentOrder = GetSingleCallReport(callConstraint).Order;
            if (previousOrder + 1 != currentOrder)
               throw new Exception("Kolejnoœæ nie zosta³a spe³niona");

            previousOrder = currentOrder;
         }
      }
   }
}