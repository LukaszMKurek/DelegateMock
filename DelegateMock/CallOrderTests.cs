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

         //Assert.That(_.WasCalled2(fun1).WithArgs(1));
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
         const int value = 5;
         var fun = For.Args<int>().Return(value).AsFunction();

         int result = fun(1);

         Assert.That(result, Is.EqualTo(value));
      }

      [Test]
      public void T16()
      {
         var fun = For.Args<int>().ReturnSequence(1, 3, 8, 20).AsFunction();

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
         var fun = For.Args((int i) => i < 2).Return(1).ForArgs(i => i < 5).Return(2).ForRest(3).AsFunction();

         Assert.That(fun(1), Is.EqualTo(1));
         Assert.That(fun(4), Is.EqualTo(2));
         Assert.That(fun(8), Is.EqualTo(3));
      }
   }

   public sealed class HolderFirst<TP1>
   {
      public Func<TP1, bool> Filter;
   }

   public sealed class HolderNext<TP1, TRet>
   {
      public Node<TP1, TRet> Node;
      public Func<TP1, bool> Filter;
   }

   public sealed class Node<TP1, TRet>
   {
      public Node<TP1, TRet> Previous;
      public Func<TP1, bool> Filter;
      public Func<TP1, TRet> Return;

      public static implicit operator Func<TP1, TRet>(Node<TP1, TRet> node)
      {
         return node.AsFunction();
      }

      public Func<TP1, TRet> AsFunction()
      {
         return p1 =>
         {
            TRet returnValue;
            if (TryGetReturnValue(this, p1, out returnValue))
               return returnValue;

            throw new Exception("No result to return");
         };
      }

      private static bool TryGetReturnValue(Node<TP1, TRet> node, TP1 p1, out TRet returnValue)
      {
         if (node.Previous != null && TryGetReturnValue(node.Previous, p1, out returnValue))
            return true;

         if (node.Filter(p1))
         {
            returnValue = node.Return(p1);
            return true;
         }

         returnValue = default(TRet);
         return false;
      }
   }

   public static class For
   {
      public static HolderFirst<TP1> Args<TP1>()
      {
         return new HolderFirst<TP1> { Filter = p1 => true };
      }

      public static HolderFirst<TP1> Args<TP1>(Func<TP1, bool> filter)
      {
         return new HolderFirst<TP1> { Filter = filter };
      }
      
      //-----
      public static Node<TP1, TRet> Return<TP1, TRet>(this HolderFirst<TP1> holder, TRet returnValue)
      {
         return new Node<TP1, TRet> { Filter = holder.Filter, Return = p1 => returnValue };
      }

      public static Node<TP1, TRet> Return<TP1, TRet>(this HolderNext<TP1, TRet> holder, TRet returnValue)
      {
         return new Node<TP1, TRet> { Filter = holder.Filter, Return = p1 => returnValue, Previous = holder.Node };
      }

      //-----
      public static Node<TP1, TRet> ReturnSequence<TP1, TRet>(this HolderFirst<TP1> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TRet> { Filter = holder.Filter, Return = p1 => sequence.GetNext() };
      }

      public static Node<TP1, TRet> ReturnSequence<TP1, TRet>(this HolderNext<TP1, TRet> holder, params TRet[] returnValues)
      {
         var sequence = new Sequence<TRet>(returnValues);
         return new Node<TP1, TRet> { Filter = holder.Filter, Return = p1 => sequence.GetNext(), Previous = holder.Node };
      }

      //-----
      public static HolderNext<TP1, TRet> ForArgs<TP1, TRet>(this Node<TP1, TRet> node, Func<TP1, bool> filter)
      {
         return new HolderNext<TP1, TRet> { Filter = filter, Node = node };
      }

      public static Node<TP1, TRet> ForRest<TP1, TRet>(this Node<TP1, TRet> node, TRet returnValue)
      {
         return new Node<TP1, TRet> { Filter = p1 => true, Return = p1 => returnValue, Previous = node };
      }
   }

   public sealed class Sequence<TItem>
   {
      private readonly Stack<TItem> _items;

      public Sequence(IEnumerable<TItem> items)
      {
         _items = new Stack<TItem>(items.Reverse());
      }

      public TItem GetNext()
      {
         lock (_items)
         {
            if (_items.Count == 0)
               throw new Exception("No more elements to return.");

            return _items.Pop();
         }
      }
   }
}
