using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DelegateMock.Implementation;
using NUnit.Framework;

namespace DelegateMock
{
   [TestFixture]
   public sealed class CallOrderTests
   {
      [Test]
      public void T01()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i*2);

         fun1(1);

         Assert.That(_.WasCalled(fun1));
      }

      [Test]
      public void T02()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i*2);

         //fun1(1);

         Assert.That(_.WasCalled(fun1) == false);
      }

      [Test]
      public void T03()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun1(1);
         fun2(1);

         _.AfterCall(fun1).NextCallWas(fun2).Verify();
      }

      [Test]
      public void T04()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun2(1);
         fun1(1);

         Assert.Throws<Exception>(() => _.AfterCall(fun1).NextCallWas(fun2).Verify());
      }

      [Test]
      public void T05()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun1(1);

         Assert.Throws<Exception>(() => _.AfterCall(fun1).NextCallWas(fun2).Verify());
      }

      [Test]
      public void T06()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun2(1);

         Assert.Throws<Exception>(() => _.AfterCall(fun1).NextCallWas(fun2).Verify());
      }

      [Test]
      public void T07()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun2(1);
         fun1(1);
         fun2(1);

         _.AfterCall(fun1).NextCallWas(fun2).Verify();
      }

      [Test]
      public void T08()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         fun1(1);

         Assert.That(_.WasCalled2(fun1).WithArgs(1));
      }

      [Test]
      public void T09()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         //fun1(1);

         Assert.That(_.WasCalled2(fun1).WithArgs(1) == false);
      }
   }

   public sealed class CallReportsWraper
   {
      public CallReportsWraper(IEnumerable<CallReport> callOrders)
      {
         CallReports = callOrders.ToList().AsReadOnly();
      }

      public ReadOnlyCollection<CallReport> CallReports { get; private set; }
   }

   public static class MockExtension2
   {
      public static CallReportsWraper WasCalled2(this Mock mock, Delegate @delegate)
      {
         if (mock.WasCalled(@delegate))
            return new CallReportsWraper(mock.GetCallReports(@delegate));

         return new CallReportsWraper(new CallReport[0]);
      }

      public static bool WithArgs(this CallReportsWraper callReportses, params object[] args)
      {
         return callReportses.CallReports.Any(c => c.Arguments.SequenceEqual(args));
      }
   }
}
