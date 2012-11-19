using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.FunctionStub
{
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