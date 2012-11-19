using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public static class PublicCallConstraintExtension
   {
      public static CallConstraint ThatThrows<TException>(this CallConstraint callOccurrence)
      {
         if (callOccurrence == null)
            throw new ArgumentNullException("callOccurrence");

         return callOccurrence.AddFilter(reports => reports.Where(x => x.Exception != null && x.Exception.GetType() == typeof(TException)));
      }

      // todo add ThatNoThrow
   }
}