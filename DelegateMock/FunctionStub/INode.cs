using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateMock.FunctionStub
{
// ReSharper disable TypeParameterCanBeVariant

   public interface INode<TRet>
   {
      Node<TRet> Previous { get; }
      Func<bool> Filter { get; }
      Func<TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TRet>
   {
      Node<TP1, TRet> Previous { get; }
      Func<TP1, bool> Filter { get; }
      Func<TP1, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TRet>
   {
      Node<TP1, TP2, TRet> Previous { get; }
      Func<TP1, TP2, bool> Filter { get; }
      Func<TP1, TP2, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TRet>
   {
      Node<TP1, TP2, TP3, TRet> Previous { get; }
      Func<TP1, TP2, TP3, bool> Filter { get; }
      Func<TP1, TP2, TP3, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> ResultBuilder { get; }
   }

   public interface INode<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>
   {
      Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Previous { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> Filter { get; }
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> ResultBuilder { get; }
   }

// ReSharper restore TypeParameterCanBeVariant
}
