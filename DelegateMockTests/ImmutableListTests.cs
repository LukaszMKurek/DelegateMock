using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using DelegateMock.Implementation;
using NUnit.Framework;

namespace DelegateMockTests
{
   [TestFixture]
   public class ImmutableListTests
   {
      [Test]
      public void T01()
      {
         var t = ImmutableList<int>.Empty;

         Contract.Assert(t.ToArray().Length == 0);
      }

      [Test]
      public void T02()
      {
         var t = ImmutableList<int>.Empty;
         t = t.Add(5);

         Contract.Assert(t.ToArray().Length == 1);
         Contract.Assert(t.ToArray().SequenceEqual(new []{ 5 }));
      }

      [Test]
      public void T03()
      {
         var t = ImmutableList<int>.Empty;
         t = t.Add(5);
         t = t.Add(8);

         Contract.Assert(t.ToArray().Length == 2);
         Contract.Assert(t.ToArray().SequenceEqual(new[] { 5, 8 }));
      }

      [Test]
      public void T04()
      {
         var t = ImmutableList<int>.Empty;
         t = t.Add(5);
         t = t.Add(8);
         t = t.Add(50);

         Contract.Assert(t.ToArray().Length == 3);
         Contract.Assert(t.ToArray().SequenceEqual(new[] { 5, 8, 50 }));
      }

      [Test]
      public void T05()
      {
         var t = ImmutableArray<int>.Empty;

         Contract.Assert(t.Length == 0);
         Contract.Assert(t.ToArray().Length == 0);
      }

      [Test]
      public void T06()
      {
         var t = ImmutableArray<int>.New(1, 2, 8);

         Contract.Assert(t.Length == 3);
         Contract.Assert(t.SequenceEqual(new[] { 1, 2, 8 }));
      }

      [Test]
      public void T07()
      {
         var t = ImmutableArray<int>.New(1, 2, 8);

         Contract.Assert(t[0] == 1);
         Contract.Assert(t[1] == 2);
         Contract.Assert(t[2] == 8);
      }
   }
}
