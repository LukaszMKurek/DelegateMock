using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public sealed class CallOrder : ICallOrder
   {
      public Mock Mock { get; private set; }
      public ICallOrder Previous { get; private set; }
      public ReadOnlyCollection<CallReport> MatchingCalls { get; private set; }
      public string Report { get; private set; }

      public CallOrder(Mock mock, ICallOrder previous, IEnumerable<CallReport> matchingCalls, string report)
      {
         Mock = mock;
         Previous = previous;
         MatchingCalls = matchingCalls.ToList().AsReadOnly();
         Report = report;
      }

      // oprócz verifi tak¿e operator true/false

      public static readonly ICallOrder Empty = null; //new CallOrderEmpty(); // po przejœciu przez object ju¿ nie widaæ typu
      /* private sealed class CallOrderEmpty : ICallOrder
       {
          public Mock Mock 
          { 
             get { throw new InvalidOperationException();}
          }

          public ICallOrder Previous
          {
             get { throw new InvalidOperationException(); }
          }

          public List<CallReport> MatchingCalls
          {
             get { throw new InvalidOperationException(); }
          }

          public string Report
          {
             get { throw new InvalidOperationException(); }
          }
       }*/
   }
}