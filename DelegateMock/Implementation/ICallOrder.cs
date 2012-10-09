using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public interface ICallOrder
   {
      Mock Mock { get; }
      ICallOrder Previous { get; }
      ReadOnlyCollection<CallReport> MatchingCalls { get; } // doda� tak�e wszystkie wo�ania
      string Report { get; }
   }
}