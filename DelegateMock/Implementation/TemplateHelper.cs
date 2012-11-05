using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using DelegateMock.FunctionStub;

namespace DelegateMock.Implementation
{
   public static class Fun
   {
      public static Func<TRet> Sequence<TRet>(params Func<TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return () => seq.GetNext()();
      }

      public static Func<TP1, TRet> Sequence<TP1, TRet>(params Func<TP1, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1) => seq.GetNext()(p1);
      }

      public static Func<TP1, TP2, TRet> Sequence<TP1, TP2, TRet>(params Func<TP1, TP2, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2) => seq.GetNext()(p1, p2);
      }

      public static Func<TP1, TP2, TP3, TRet> Sequence<TP1, TP2, TP3, TRet>(params Func<TP1, TP2, TP3, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3) => seq.GetNext()(p1, p2, p3);
      }

      public static Func<TP1, TP2, TP3, TP4, TRet> Sequence<TP1, TP2, TP3, TP4, TRet>(params Func<TP1, TP2, TP3, TP4, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4) => seq.GetNext()(p1, p2, p3, p4);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5) => seq.GetNext()(p1, p2, p3, p4, p5);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6) => seq.GetNext()(p1, p2, p3, p4, p5, p6);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>[] funcSequence)
      {
         VerifiContracts(funcSequence);
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>>() != null);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
      }

      private static Sequence<T> CreateSequence<T>(T[] funcSequence)
      {
         return new Sequence<T>(funcSequence);
      }
      
      [ContractArgumentValidator]
      private static void VerifiContracts<T>(T[] funcSequence) where T : class
      {
         if (funcSequence == null)
            throw new ArgumentNullException("funcSequence");
         if (funcSequence.Length == 0)
            throw new ArgumentException("funcSequence must be greather than 0.");
         if (funcSequence.Any(f => f == null))
            throw new ArgumentException("Any delegate in funcSequence cannot be null.");
         Contract.EndContractBlock();
      }
   }
}
