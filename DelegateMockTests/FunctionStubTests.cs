using System;
using System.Collections.Generic;
using System.Linq;
using DelegateMock.FunctionStub;
using DelegateMock.Implementation;
using NUnit.Framework;

namespace DelegateMockTests
{
   [TestFixture]
   public sealed class FunctionStubTests
   {
      [Test]
      public void T15()
      {
         const int value = 5;
         var fun = For.Args<int>().Return(value).AsFunc();

         int result = fun(1);

         Assert.That(result, Is.EqualTo(value));
      }

      [Test]
      public void T16()
      {
         var fun = For.Args<int>().ReturnSequence(1, 3, 8, 20).AsFunc();

         Assert.That(fun(1), Is.EqualTo(1));
         Assert.That(fun(1), Is.EqualTo(3));
         Assert.That(fun(1), Is.EqualTo(8));
         Assert.That(fun(1), Is.EqualTo(20));
         var exception = Assert.Throws<Exception>(() => fun(1));
         Assert.That(exception.Message, Is.EqualTo("No more elements to return."));
      }

      [Test]
      public void T17()
      {
         var fun = For.Args((int i) => i < 2).Return(1).ForArgs(i => i < 5).Return(2).ForRest(3).AsFunc();

         Assert.That(fun(1), Is.EqualTo(1));
         Assert.That(fun(4), Is.EqualTo(2));
         Assert.That(fun(8), Is.EqualTo(3));
      }

      [Test]
      public void T18()
      {
         var fun = For.Args(8).Return(1).ForArgs(9).Return(2).AsFunc();

         Assert.That(fun(8), Is.EqualTo(1));
         Assert.That(fun(9), Is.EqualTo(2));
         var exception = Assert.Throws<Exception>(() => fun(10));
         Assert.That(exception.Message, Is.EqualTo("No result to return."));
      }

      [Test]
      public void T19()
      {
         var fun = For.Args(8).Return(1).ForArgs(9).ReturnSequence(2, 3, 4).AsFunc();

         Assert.That(fun(8), Is.EqualTo(1));
         Assert.That(fun(9), Is.EqualTo(2));
         Assert.That(fun(9), Is.EqualTo(3));
         Assert.That(fun(9), Is.EqualTo(4));
         var exception = Assert.Throws<Exception>(() => fun(9));
         Assert.That(exception.Message, Is.EqualTo("No more elements to return."));
      }

      [Test]
      public void T20()
      {
         var _ = Mock.New;
         var fun = _.Func(For.Args(8).Return(1).ForArgs(9).Return(2));

         Assert.That(fun(8), Is.EqualTo(1));
      }
   }
}
