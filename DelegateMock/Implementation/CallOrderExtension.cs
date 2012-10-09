using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateMock.Implementation
{
   public static class CallOrderExtension
   {
      public static CallOrder NextCallWas(this ICallOrder callOrder, Delegate @delegate)
      {
         Mock mock = callOrder.Mock;

         string report = "Method was not called.";
         IEnumerable<CallReport> matchingCalls = new List<CallReport>();

         if (mock.WasCalled(@delegate))
         {
            report = null;
            if (callOrder.MatchingCalls.Any())
            {
               int firstCallOrder = callOrder.MatchingCalls.Min(pc => pc.Order);
               matchingCalls = mock.GetCallReports(@delegate).Where(c => c.Order > firstCallOrder);
               if (!matchingCalls.Any())
                  report = "Expected Call do not apear.";
            }
         }

         return new CallOrder(
            mock: mock,
            previous: callOrder,
            matchingCalls: matchingCalls,
            report: report);
      }

      public static void Verify(this ICallOrder callOrder)
      {
         var report = new StringBuilder();
         ICallOrder call = callOrder;
         do
         {
            if (call.Report != null)
               report.AppendLine(call.Report);

            call = call.Previous;
         } while (call != CallOrder.Empty);

         if (report.Length != 0)
            throw new Exception(report.ToString());
      }
   }
}
