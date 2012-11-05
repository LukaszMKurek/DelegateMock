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
      public void AssertThatWasCalled(CallAssert callAssert)
      {
         if (callAssert == null)
            throw new ArgumentNullException("callAssert");

         if (GetCallRaportsFilteredBy(callAssert).Count == 0)
            throw new Exception("Funkcja nie by³a wo³ana");
      }
      
      private List<CallReport> GetCallRaportsFilteredBy(CallAssert callAssert)
      {
         return callAssert.FilterCallRaport(GetCallReports(callAssert.Delegate));
      }

      private CallReport GetSingleCallReport(CallAssert callAssert)
      {
         List<CallReport> callRaports = GetCallRaportsFilteredBy(callAssert);
         if (callRaports.Count == 0) // todo eby wyj¹tek by³ wyra¿ny wyprowadzic go delegat¹ mo¿e
            throw new Exception("Funkcja nie by³a wo³ana");

         return callRaports[0];
      }

      // na extension przerobiæ
      public void AssertThatWasCalledInOrder(params CallAssert[] callAsserts)
      {
         if (callAsserts == null)
            throw new ArgumentNullException("callAsserts");
         if (callAsserts.Length == 0)
            throw new Exception("Z³e u¿ycie.");
         Contract.Requires(Contract.ForAll(callAsserts, call => call != null));

         CallAssert previousCall = callAsserts[0];
         int previousOrder = GetSingleCallReport(previousCall).Order;
         
         foreach (var callAssert in callAsserts.Skip(1))
         {
            Contract.Assume(callAssert != null); // todo
            //AssertThatWasCalled(callAssert);

            int currentOrder = GetSingleCallReport(callAssert).Order;
            if (previousOrder + 1 != currentOrder)
               throw new Exception("Kolejnoœæ nie zosta³a spe³niona");

            previousOrder = currentOrder;
         }
      }
   }

   public static class MockExtension
   {
      public static Func<TP1, TRet> Func<TP1, TRet>(this Mock self, Node<TP1, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TRet> Func<TP1, TRet>(this Mock self, Func<TP1, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

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
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };
         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
   }
}