using System;
using System.Collections.Generic;
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

         //Assert.That(_.WasCalled(fun1));
         _.AssertThatWasCalled(fun1);
      }

      [Test]
      public void T02()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i*2);

         //fun1(1);

         //Assert.That(_.WasCalled(fun1) == false);
         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalled(fun1));
         Assert.That(exception.Message, Is.EqualTo("Funkcja nie była wołana"));
      }

      [Test]
      public void T03()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun1(1);
         fun2(1);

         //_.AfterCall(fun1).NextCallWas(fun2).Verify();
         //_.AssertThat(fun1.WasCalled().AndNextCalledWas(fun2));
         _.AssertThatWasCalledInOrder(fun1, fun2);
      }

      [Test]
      public void T04()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun2(1);
         fun1(1);

         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalledInOrder(fun1, fun2));
         Assert.That(exception.Message, Is.EqualTo("Kolejność nie została spełniona"));
      }

      [Test]
      public void T05()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun1(1);

         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalledInOrder(fun1, fun2));
         Assert.That(exception.Message, Is.EqualTo("Funkcja nie była wołana"));
      }

      [Test]
      public void T06()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun2(1);

         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalledInOrder(fun1, fun2));
         Assert.That(exception.Message, Is.EqualTo("Funkcja nie była wołana"));
      }

      [Test]
      public void T07()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun2(1); // można doprecyzować że chodzi o first call
         fun1(1);
         fun2(1);

         //_.AfterCall(fun1).NextCallWas(fun2).Verify();
         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalledInOrder(fun1, fun2));
         Assert.That(exception.Message, Is.EqualTo("Kolejność nie została spełniona"));
      }

      [Test]
      public void T07_1()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun2(1);
         fun1(1);
         fun2(2);

         _.AssertThatWasCalledInOrder(fun1, fun2.WithArgs(2));
      }

      [Test]
      public void T07_3()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         fun1(2);
         fun1(3);
         fun1(2);

         _.AssertThatWasCalledInOrder(fun1.WithArgs(2), fun1.WithArgs(3));
         _.AssertThatWasCalledInOrder(fun1.WithArgs(3), fun1.WithArgs(2).SecondCall());
         _.AssertThatWasCalledInOrder(fun1.WithArgs(3), fun1.WithArgs(3)); // todo źle
      }

      [Test]
      public void T07_2()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);
         var fun2 = _.Func((int i) => i * 3);

         fun2(1);
         fun1(1);
         fun2(1);

         _.AssertThatWasCalledInOrder(fun1, fun2.SecondCall().WithArgs(1));
      }

      [Test]
      public void T08()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         fun1(1);

         //Assert.That(_.WasCalled2(fun1).WithArgs(1));
         _.AssertThatWasCalled(fun1.WithArgs(1));
      }

      [Test]
      public void T09()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         fun1(1);
         fun1(2);

         _.AssertThatWasCalled(fun1.WithArgs(2));
      }

      [Test]
      public void T10()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         fun1(1);

         //Assert.That(_.WasCalled2(fun1).WithArgs(1));
         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalled(fun1.WithArgs(2)));
         Assert.That(exception.Message, Is.EqualTo("Funkcja nie była wołana"));
      }

      [Test]
      public void T11()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         //fun1(1);

         //Assert.That(_.WasCalled2(fun1).WithArgs(1) == false); // .Verifi może zostać zapomniane 
         //_.AssertThat(_.WasCalled2(fun1).WithArgs(1));
         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalled(fun1.WithArgs(1)));
         Assert.That(exception.Message, Is.EqualTo("Funkcja nie była wołana"));
      }
   }
}
