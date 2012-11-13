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
         Contract.Ensures(Contract.Result<Func<TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return () => seq.GetNext()();
      }

      public static Action Sequence(params Action[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return () => seq.GetNext()();
      }

      public static Func<TP1, TRet> Sequence<TP1, TRet>(params Func<TP1, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1) => seq.GetNext()(p1);
      }

      public static Action<TP1> Sequence<TP1>(params Action<TP1>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1) => seq.GetNext()(p1);
      }

      public static Func<TP1, TP2, TRet> Sequence<TP1, TP2, TRet>(params Func<TP1, TP2, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2) => seq.GetNext()(p1, p2);
      }

      public static Action<TP1, TP2> Sequence<TP1, TP2>(params Action<TP1, TP2>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2) => seq.GetNext()(p1, p2);
      }

      public static Func<TP1, TP2, TP3, TRet> Sequence<TP1, TP2, TP3, TRet>(params Func<TP1, TP2, TP3, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3) => seq.GetNext()(p1, p2, p3);
      }

      public static Action<TP1, TP2, TP3> Sequence<TP1, TP2, TP3>(params Action<TP1, TP2, TP3>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3) => seq.GetNext()(p1, p2, p3);
      }

      public static Func<TP1, TP2, TP3, TP4, TRet> Sequence<TP1, TP2, TP3, TP4, TRet>(params Func<TP1, TP2, TP3, TP4, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4) => seq.GetNext()(p1, p2, p3, p4);
      }

      public static Action<TP1, TP2, TP3, TP4> Sequence<TP1, TP2, TP3, TP4>(params Action<TP1, TP2, TP3, TP4>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4) => seq.GetNext()(p1, p2, p3, p4);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5) => seq.GetNext()(p1, p2, p3, p4, p5);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5> Sequence<TP1, TP2, TP3, TP4, TP5>(params Action<TP1, TP2, TP3, TP4, TP5>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5) => seq.GetNext()(p1, p2, p3, p4, p5);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6) => seq.GetNext()(p1, p2, p3, p4, p5, p6);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6> Sequence<TP1, TP2, TP3, TP4, TP5, TP6>(params Action<TP1, TP2, TP3, TP4, TP5, TP6>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6) => seq.GetNext()(p1, p2, p3, p4, p5, p6);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(params Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> Sequence<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(params Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>[] funcSequence)
      {
         Contract.Ensures(Contract.Result<Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>>() != null);
			VerifiContracts(funcSequence);

         var seq = CreateSequence(funcSequence);
         return (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => seq.GetNext()(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
      }

      private static Sequence<T> CreateSequence<T>(T[] funcSequence)
      {
         return new Sequence<T>(funcSequence);
      }
      
      //[ContractArgumentValidator] //todo this attribute ony in 4.5
      private static void VerifiContracts<T>(T[] funcSequence) where T : class
      {
         if (funcSequence == null)
            throw new ArgumentNullException("funcSequence");
         if (funcSequence.Length == 0)
            throw new ArgumentException("funcSequence must be greather than 0.");
         if (funcSequence.Any(f => f == null))
            throw new ArgumentException("Any delegate in funcSequence cannot be null.");
         //Contract.EndContractBlock();
      }
   }
}
