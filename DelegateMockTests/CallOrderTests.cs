using System;
using System.Collections.Generic;
using System.Linq;
using DelegateMock.FunctionStub;
using DelegateMock.Implementation;
using NUnit.Framework;

namespace DelegateMockTests
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

         _.AssertThatWasCalled(fun1);
      }

      [Test]
      public void T02()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i*2);

         //fun1(1);

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

         fun2(1);
         fun1(1);
         fun2(1);

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

         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalledInOrder(fun1.WithArgs(3), fun1.WithArgs(3)));
         Assert.That(exception.Message, Is.EqualTo("Kolejność nie została spełniona"));
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
      public void T07_4()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         fun1(2);
         fun1(3);
         fun1(3);

         _.AssertThatWasCalledInOrder(fun1.WithArgs(3), fun1.WithArgs(3).SecondCall());
      }

      // todo CalledTwice()

      [Test]
      public void T08()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         fun1(1);

         _.AssertThatWasCalled(fun1.WithArgs(1));
      }

      [Test]
      public void T08_1()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         fun1(4);

         _.AssertThatWasCalled(fun1.WithArgs(i => i > 2));
         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalled(fun1.WithArgs(i => i < 4)));
         Assert.That(exception.Message, Is.EqualTo("Funkcja nie była wołana"));
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

         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalled(fun1.WithArgs(2)));
         Assert.That(exception.Message, Is.EqualTo("Funkcja nie była wołana"));
      }

      [Test]
      public void T11()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => i * 2);

         //fun1(1);

         var exception = Assert.Throws<Exception>(() => _.AssertThatWasCalled(fun1.WithArgs(1)));
         Assert.That(exception.Message, Is.EqualTo("Funkcja nie była wołana"));
      }

      // ReSharper disable CSharpWarnings::CS0162
      // ReSharper disable EmptyGeneralCatchClause
      [Test]
      public void T12()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => { 
            throw new Exception();
            return 0;
         });

         try
         {
            fun1(2);
         }
         catch
         {}
         
         _.AssertThatWasCalled(fun1.WithArgs(2));
      }

      [Test]
      public void T13()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) =>
         {
            throw new Exception();
            return 0;
         });

         try
         {
            fun1(2);
         }
         catch
         { }

         _.AssertThatWasCalled(fun1.WithArgs(2).ThatThrows<Exception>());
      }
      // ReSharper restore EmptyGeneralCatchClause
      // ReSharper restore CSharpWarnings::CS0162

      [Test]
      public void T14()
      {
         var _ = Mock.New;
         var fun1 = _.Func((int i) => 5);

         fun1(2);
         
         _.AssertThatWasCalled(fun1.WithArgs(2).ThatReturn(5));
      }

      [Test]
      public void T15()
      {
         var fun = Fun.Sequence((int i) => 1, i => 2, i => 7);

         var r1 = fun(1);
         var r2 = fun(1);
         var r3 = fun(1);

         Assert.That(r1, Is.EqualTo(1));
         Assert.That(r2, Is.EqualTo(2));
         Assert.That(r3, Is.EqualTo(7));
      }
   }
}
