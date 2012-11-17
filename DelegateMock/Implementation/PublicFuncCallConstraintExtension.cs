using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public static class PublicCallConstraintExtension
   {
      public static CallConstraint ThatThrows<TException>(this CallConstraint callOccurrence)
      {
         if (callOccurrence == null)
            throw new ArgumentNullException("callOccurrence");

         return callOccurrence.AddFilter(reports => reports.Where(x => x.Exception != null && x.Exception.GetType() == typeof(TException)));
      }

      // todo add ThatNoThrow
   }

   public static class PublicFuncCallConstraintExtension
   {
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
   }

   public static class PublicActionCallConstraintExtension
   {
      public static ActionCallConstraint<TP1> WithArgs<TP1>(this Action<TP1> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1>)action, arguments);
      }

      public static ActionCallConstraint<TP1> WithArgs<TP1>(this ActionCallConstraint<TP1> actionCallConstraint, params object[] arguments)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }
      // todo add ExpceptWithArgs

      //-----------------------

      // todo not working with nullable types
      public static ActionCallConstraint<TP1> WithArgs<TP1>(this Action<TP1> action, Func<TP1, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1> WithArgs<TP1>(this ActionCallConstraint<TP1> actionCallConstraint, Func<TP1, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1> SecondCall<TP1>(this Action<TP1> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1>)action);
      }

      public static ActionCallConstraint<TP1> SecondCall<TP1>(this ActionCallConstraint<TP1> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
   }
}