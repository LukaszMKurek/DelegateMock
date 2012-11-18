using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateMock.FunctionStub
{
// ReSharper disable TypeParameterCanBeVariant

   public interface IHolderNext<TP1, TRet>
   {
      Node<TP1, TRet> Node { get; }
      Func<TP1, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TRet>
   {
      Node<TP1, TP2, TRet> Node { get; }
      Func<TP1, TP2, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TRet>
   {
      Node<TP1, TP2, TP3, TRet> Node { get; }
      Func<TP1, TP2, TP3, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> Filter { get; }
   }

   public interface IHolderNext<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Node { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> Filter { get; }
   }

// ReSharper restore TypeParameterCanBeVariant
}
