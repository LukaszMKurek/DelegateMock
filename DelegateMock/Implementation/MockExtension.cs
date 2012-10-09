using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public static class MockExtension
   {
      public static CallOrder AfterCall(this Mock mock, Delegate @delegate)
      {
         string report = "Method was not called.";
         IEnumerable<CallReport> matchingCalls = new List<CallReport>();

         if (mock.WasCalled(@delegate))
         {
            matchingCalls = mock.GetCallReports(@delegate);
            report = null;
         }

         return new CallOrder(
            mock: mock,
            previous: CallOrder.Empty,
            matchingCalls: matchingCalls,
            report: report);
      }
   }
}