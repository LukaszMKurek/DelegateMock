using System.Collections;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public interface IImmutableList<T, out TList> : IEnumerable<T> where TList : IImmutableList<T, TList>
   {
      [Pure]
      int Length { get; }

      [Pure]
      TList Add(T item);

      [Pure]
      T[] ToArray();
   }

   public interface IImmutableList<T> : IImmutableList<T, IImmutableList<T>>
   {}

   public abstract class ImmutableListContract<T> : IImmutableList<T, ImmutableListContract<T>>, IImmutableList<T>
   {
      public int Length
      {
         get
         {
            Contract.Ensures(Contract.Result<int>() >= 0);
            
            return 0;
         }
      }

      public ImmutableListContract<T> Add(T item)
      {
         Contract.Ensures(Contract.Result<ImmutableListContract<T>>() != null);
         Contract.Ensures(Contract.Result<ImmutableListContract<T>>().Length == Length + 1);

         return null;
      }

      IImmutableList<T> IImmutableList<T, IImmutableList<T>>.Add(T item)
      {
         Contract.Ensures(Contract.Result<IImmutableList<T>>() != null);
         Contract.Ensures(Contract.Result<IImmutableList<T>>().Length == Length + 1);

         return Add(item);
      }

      public T[] ToArray()
      {
         Contract.Ensures(Contract.Result<T[]>() != null);
         Contract.Ensures(Contract.Result<T[]>().Length == Length);

         return null;
      }

      IEnumerator<T> IEnumerable<T>.GetEnumerator()
      {
         return ((IEnumerable<T>)ToArray()).GetEnumerator();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return ToArray().GetEnumerator();
      }
   }
   
   public sealed class ImmutableList<T> : IImmutableList<T, ImmutableList<T>>, IImmutableList<T>
   {
      private readonly T _head;
      private readonly ImmutableList<T> _tail;
      private readonly int _count;

      private ImmutableList(T head, ImmutableList<T> tail, int count)
      {
         Contract.Requires(tail != null);
         Contract.Requires(tail._count == count - 1);
         Contract.Requires(count > 0);
         Contract.Ensures(_count > 0);
         Contract.Ensures(_tail != null);
         Contract.Ensures(_tail._count == _count - 1);
         Contract.Ensures(Length == _count);

         _head = head;
         _tail = tail;
         _count = count;
      }

      private ImmutableList()
      {
         Contract.Ensures(_count == 0);
         Contract.Ensures(_tail == null);

         _head = default(T);
         _tail = null;
         _count = 0;
      }

      [Pure]
      public static ImmutableList<T> Empty
      {
         get
         {
            Contract.Ensures(Contract.Result<ImmutableList<T>>() != null);
            Contract.Ensures(Contract.Result<ImmutableList<T>>().Length == 0);
            
            return new ImmutableList<T>() ;
         }
      }

      [ContractInvariantMethod]
      private void Inv()
      {
         Contract.Invariant(Length == _count);
         Contract.Invariant(_count == 0 || (_count > 0 && _tail != null && _tail._count == _count - 1));
      }

      [Pure]
      public int Length
      {
         get
         {
            Contract.Ensures(Contract.Result<int>() == _count);

            return _count;
         }
      }

      [Pure]
      public ImmutableList<T> Add(T item)
      {
         Contract.Ensures(Contract.Result<ImmutableList<T>>()._tail == this);
         Contract.Ensures(Object.Equals(Contract.Result<ImmutableList<T>>()._head, item));
         Contract.Ensures(Contract.Result<ImmutableList<T>>() != null);
         Contract.Ensures(Contract.Result<ImmutableList<T>>().Length == Length + 1);

         return new ImmutableList<T>(item, this, _count + 1);
      }

      IImmutableList<T> IImmutableList<T, IImmutableList<T>>.Add(T item)
      {
         return Add(item);
      }

      [Pure]
      public T[] ToArray()
      {
         Contract.Ensures(Contract.Result<T[]>() != null);
         Contract.Ensures(Contract.Result<T[]>().Length == Length);

         var array = new T[_count];
         int i = _count - 1;
         ImmutableList<T> curr = this;
         while(curr._count > 0)
         {
            Contract.Assert(i >= 0);
            array[i] = curr._head;

            Contract.Assume(curr._tail != null);
            Contract.Assume(curr._tail._count == curr._count - 1);
            curr = curr._tail;
            i -= 1;
         }
         Contract.Assert(i == -1);

         return array;
      }

      [Pure]
      IEnumerator<T> IEnumerable<T>.GetEnumerator()
      {
         return ((IEnumerable<T>)ToArray()).GetEnumerator();
      }

      [Pure]
      IEnumerator IEnumerable.GetEnumerator()
      {
         return ToArray().GetEnumerator();
      }
   }

   //-------------------------------------------------------------------
   [ContractClass(typeof(ImmutableArrayContract<>))]
   public interface IImmutableArray<out T> : IEnumerable<T>
   {
      [Pure]
      int Length { get; }

      [Pure]
      T this[int i] { get; }

      [Pure]
      T[] ToArray();
   }

   [ContractClassFor(typeof(IImmutableArray<>))]
   public abstract class ImmutableArrayContract<T> : IImmutableArray<T>
   {
      public int Length
      {
         get
         {
            Contract.Ensures(Contract.Result<int>() >= 0);

            return 0;
         }
      }

      public T this[int i]
      {
         get
         {
            Contract.Requires(i >= 0 && i < Length);

            return default(T);
         }
      }

      public T[] ToArray()
      {
         Contract.Ensures(Contract.Result<T[]>() != null);
         Contract.Ensures(Contract.Result<T[]>().Length == Length);

         return null;
      }

      public IEnumerator<T> GetEnumerator()
      {
         throw new Exception();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }

   public struct ImmutableArray<T> : IImmutableArray<T>
   {
      private readonly T[] _array;

      private ImmutableArray(T[] array)
      {
         Contract.Requires(array != null);
         Contract.Ensures(Contract.ValueAtReturn(out _array) == array);

         _array = array;
         Contract.Assert(_array == array);
      }

      [ContractInvariantMethod]
      private void Inv()
      {
         Contract.Invariant(_array != null);
      }

      [Pure]
      public static ImmutableArray<T> Empty
      {
         get
         {
            Contract.Ensures(Contract.Result<ImmutableArray<T>>().Length == 0);

            var immutableEmptyArray = new ImmutableArray<T>(new T[0]);
            Contract.Assume(immutableEmptyArray.Length == 0);
            return immutableEmptyArray;
         }
      }

      [Pure]
      public static ImmutableArray<T> FromArray(T[] array)
      {
         if (array == null)
            throw new ArgumentNullException("array");
         Contract.Ensures(Contract.Result<ImmutableArray<T>>().Length == array.Length);
         
         var immutableArray = new ImmutableArray<T>((T[])array.Clone());
         Contract.Assume(immutableArray.Length == array.Length);
         return immutableArray;
      }

      [Pure]
      public static ImmutableArray<T> New(params T[] array)
      {
         if (array == null)
            throw new ArgumentNullException("array");
         Contract.Ensures(Contract.Result<ImmutableArray<T>>().Length == array.Length);

         var immutableArray = new ImmutableArray<T>((T[])array.Clone());
         Contract.Assume(immutableArray.Length == array.Length);
         return immutableArray;
      }

      public int Length
      {
         get { return (_array != null) ? _array.Length : 0; }
      }

      public T this[int i]
      {
         get { return _array[i]; }
      }

      public T[] ToArray()
      {
         var clone = (T[])(_array ?? new T[0]).Clone();
         Contract.Assume(clone.Length == Length);
         return clone;
      }

      [Pure]
      IEnumerator<T> IEnumerable<T>.GetEnumerator()
      {
         return ((IEnumerable<T>)_array ?? new T[0]).GetEnumerator();
      }

      [Pure]
      IEnumerator IEnumerable.GetEnumerator()
      {
         return (_array ?? new T[0]).GetEnumerator();
      }
   }
}