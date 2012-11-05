using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public struct CallReport
   {
      private readonly ImmutableArray<object> _arguments; // rozró¿niaæ wejœciowe i wyjœciowe
      private readonly object _returnValue;
      private readonly Exception _exception;
      private readonly int _order;

      public CallReport(ImmutableArray<object> arguments, object returnValue, Exception exception, int order)
      {
         Contract.Requires(order >= 0);

         _arguments = arguments;
         _returnValue = returnValue;
         _exception = exception;
         _order = order;
      }

      public ImmutableArray<object> Arguments
      {
         get { return _arguments; }
      }

      public object ReturnValue
      {
         get { return _returnValue; }
      }

      public Exception Exception
      {
         get { return _exception; }
      }

      public int Order
      {
         get { return _order; }
      }
   }
}