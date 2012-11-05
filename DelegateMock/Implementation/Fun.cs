using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using DelegateMock.FunctionStub;

namespace DelegateMock.Implementation
{
   /*public static class Fun
   {
      public static Func<TP1, TRet> Sequence<TP1, TRet>(params Func<TP1, TRet>[] funcSequence)
      {
         if (funcSequence == null)
            throw new ArgumentNullException("funcSequence");
         if (funcSequence.Length == 0)
            throw new ArgumentException("funcSequence must be greather than 0.");
         Contract.Requires(Contract.ForAll(funcSequence, f => f != null));
         Contract.Ensures(Contract.Result<Func<TP1, TRet>>() != null);

         var seq = new Sequence<Func<TP1, TRet>>(funcSequence);
         return p1 => seq.GetNext()(p1);
      }
   }*/
}
