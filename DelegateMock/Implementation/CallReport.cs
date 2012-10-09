using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public struct CallReport
   {
      private readonly object[] _arguments; // rozró¿niaæ wejœciowe i wyjœciowe
      private readonly object _returnValue;
      private readonly Exception _exception;
      private readonly int _order;
      private static readonly object[] s_emptyArgumentArray = new object[0];

      public CallReport(object[] arguments, object returnValue, Exception exception, int order)
      {
         _arguments = arguments;
         _returnValue = returnValue;
         _exception = exception;
         _order = order;
      }

      public object[] Arguments
      {
         get { return _arguments ?? s_emptyArgumentArray; }
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