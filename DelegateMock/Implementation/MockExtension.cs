using System.Linq;
using System.Collections.Generic;
using System;
using DelegateMock.FunctionStub;

namespace DelegateMock.Implementation
{
   public static class MockExtension1
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

      public static Action<TP1> Action<TP1>(this Mock self, Action<TP1> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1> wrapDelegateTemp = null;
         Action<TP1> wrapDelegate = p1 =>
         {
            Exception exception = null;

            try
            {
               action(p1);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
   }
}