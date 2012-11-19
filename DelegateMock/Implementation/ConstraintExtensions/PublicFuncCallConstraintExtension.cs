using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public static class PublicFuncCallConstraintExtension
   {
      public static FuncCallConstraint<TRet> WithArgs<TRet>(this Func<TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TRet>)func, arguments);
      }

      public static FuncCallConstraint<TRet> WithArgs<TRet>(this FuncCallConstraint<TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TRet> WithArgs<TRet>(this Func<TRet> func, Func<bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TRet> WithArgs<TRet>(this FuncCallConstraint<TRet> funcCallConstraint, Func<bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TRet> SecondCall<TRet>(this Func<TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TRet>)func);
      }

      public static FuncCallConstraint<TRet> SecondCall<TRet>(this FuncCallConstraint<TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TRet> ThatReturn<TRet>(this FuncCallConstraint<TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TRet> WithArgs<TP1, TRet>(this Func<TP1, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TRet> WithArgs<TP1, TRet>(this FuncCallConstraint<TP1, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TRet> WithArgs<TP1, TRet>(this Func<TP1, TRet> func, Func<TP1, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TRet> WithArgs<TP1, TRet>(this FuncCallConstraint<TP1, TRet> funcCallConstraint, Func<TP1, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TRet> SecondCall<TP1, TRet>(this Func<TP1, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TRet> SecondCall<TP1, TRet>(this FuncCallConstraint<TP1, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TRet> ThatReturn<TP1, TRet>(this FuncCallConstraint<TP1, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TRet> WithArgs<TP1, TP2, TRet>(this Func<TP1, TP2, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TRet> WithArgs<TP1, TP2, TRet>(this FuncCallConstraint<TP1, TP2, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TRet> WithArgs<TP1, TP2, TRet>(this Func<TP1, TP2, TRet> func, Func<TP1, TP2, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TRet> WithArgs<TP1, TP2, TRet>(this FuncCallConstraint<TP1, TP2, TRet> funcCallConstraint, Func<TP1, TP2, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TRet> SecondCall<TP1, TP2, TRet>(this Func<TP1, TP2, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TRet> SecondCall<TP1, TP2, TRet>(this FuncCallConstraint<TP1, TP2, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TRet> ThatReturn<TP1, TP2, TRet>(this FuncCallConstraint<TP1, TP2, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TRet> WithArgs<TP1, TP2, TP3, TRet>(this Func<TP1, TP2, TP3, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TRet> WithArgs<TP1, TP2, TP3, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TRet> WithArgs<TP1, TP2, TP3, TRet>(this Func<TP1, TP2, TP3, TRet> func, Func<TP1, TP2, TP3, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TRet> WithArgs<TP1, TP2, TP3, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TRet> funcCallConstraint, Func<TP1, TP2, TP3, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TRet> SecondCall<TP1, TP2, TP3, TRet>(this Func<TP1, TP2, TP3, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TRet> SecondCall<TP1, TP2, TP3, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TRet> ThatReturn<TP1, TP2, TP3, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> WithArgs<TP1, TP2, TP3, TP4, TRet>(this Func<TP1, TP2, TP3, TP4, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> WithArgs<TP1, TP2, TP3, TP4, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> WithArgs<TP1, TP2, TP3, TP4, TRet>(this Func<TP1, TP2, TP3, TP4, TRet> func, Func<TP1, TP2, TP3, TP4, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> WithArgs<TP1, TP2, TP3, TP4, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> SecondCall<TP1, TP2, TP3, TP4, TRet>(this Func<TP1, TP2, TP3, TP4, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> SecondCall<TP1, TP2, TP3, TP4, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> ThatReturn<TP1, TP2, TP3, TP4, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>)func, arguments);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> funcCallConstraint, params object[] arguments)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> func, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>)func, argsFilter);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> funcCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> argsFilter)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>)func);
      }

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> funcCallConstraint)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> ThatReturn<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this FuncCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> funcCallConstraint, TRet returnValue)
      {
         if (funcCallConstraint == null)
            throw new ArgumentNullException("funcCallConstraint");

         return funcCallConstraint.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
      //----------------------------------------------------------------------------------------------------------------

   }
}
