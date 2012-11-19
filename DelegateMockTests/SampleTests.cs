using System;
using System.Collections.Generic;
using System.Linq;
using DelegateMock.FunctionStub;
using DelegateMock.Implementation;
using NUnit.Framework;

namespace DelegateMockTests
{
   [TestFixture]
   public sealed class SampleTests
   {
      [Test]
      public void T01()
      {
         var _ = Mock.New;
         Func<int, int> fun1 = _.Func((int i) => i);
         Func<int, int> fun2 = _.Func((int i) => i);

         fun1(1);
         fun2(1);

         _.AssertThatWasCalledInOrder(fun1, fun2);
      }

      [Test]
      public void T02()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i);
         var fun2 = _.Func((int i) => i);

         fun2(1);
         fun1(1);

         Assert.Throws<Exception>(() => _.AssertThatWasCalledInOrder(fun1, fun2));
      }

      [Test]
      public void T03()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i);

         fun1(4);

         _.AssertThatWasCalled(fun1.WithArgs(i => i > 2));
         Assert.Throws<Exception>(() => _.AssertThatWasCalled(fun1.WithArgs(i => i < 4)));
      }

      [Test]
      public void T04()
      {
         var fun = Fun.Sequence((int i) => 1, i => 2, i => 7);

         var r1 = fun(1);
         var r2 = fun(1);
         var r3 = fun(1);

         Assert.That(r1, Is.EqualTo(1));
         Assert.That(r2, Is.EqualTo(2));
         Assert.That(r3, Is.EqualTo(7));
      }

      [Test]
      public void T05()
      {
         var fun = For.Args((int i) => i < 2).Return(1).ForArgs(i => i < 5).Return(2).ForRest(3).AsFunc();

         Assert.That(fun(1), Is.EqualTo(1));
         Assert.That(fun(4), Is.EqualTo(2));
         Assert.That(fun(8), Is.EqualTo(3));
      }
   }
}
