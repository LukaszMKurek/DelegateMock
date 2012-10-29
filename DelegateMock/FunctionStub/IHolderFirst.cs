
using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateMock.FunctionStub
{
// ReSharper disable TypeParameterCanBeVariant

   public interface IHolderFirst
   {
      Func<bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1>
   {
      Func<TP1, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2>
   {
      Func<TP1, TP2, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3>
   {
      Func<TP1, TP2, TP3, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4>
   {
      Func<TP1, TP2, TP3, TP4, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5>
   {
      Func<TP1, TP2, TP3, TP4, TP5, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> Filter { get; }
   }
   
   public interface IHolderFirst<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>
   {
      Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> Filter { get; }
   }
   
// ReSharper restore TypeParameterCanBeVariant
}
