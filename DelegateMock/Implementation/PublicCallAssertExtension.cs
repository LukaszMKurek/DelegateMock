using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public static class PublicCallAssertExtension
   {
      public static CallAssert<TP1, TRet> WithArgs<TP1, TRet>(this Func<TP1, TRet> func, params object[] arguments)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((CallAssert<TP1, TRet>)func, arguments);
      }

      public static CallAssert<TP1, TRet> WithArgs<TP1, TRet>(this CallAssert<TP1, TRet> callAssert, params object[] arguments)
      {
         if (callAssert == null)
            throw new ArgumentNullException("callAssert");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return callAssert.AddFilter(reports => reports.Where(x => x.Arguments.SequenceEqual(arguments)));
      }

      //-----------------------

      // todo not working with nullable types
      // delegaty nie generyczne nie bêd¹ typowane bo nie op³aca siê ich otaczaæ w statyczn¹ otoczkê
      public static CallAssert<TP1, TRet> WithArgs<TP1, TRet>(this Func<TP1, TRet> func, Func<TP1, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((CallAssert<TP1, TRet>)func, argsFilter);
      }

      public static CallAssert<TP1, TRet> WithArgs<TP1, TRet>(this CallAssert<TP1, TRet> func, Func<TP1, bool> argsFilter)
      {
         if (func == null)
            throw new ArgumentNullException("func");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return func.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static CallAssert<TP1, TRet> SecondCall<TP1, TRet>(this Func<TP1, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         return SecondCall((CallAssert<TP1, TRet>)func);
      }

      public static CallAssert<TP1, TRet> SecondCall<TP1, TRet>(this CallAssert<TP1, TRet> callAssert)
      {
         if (callAssert == null)
            throw new ArgumentNullException("callAssert");

         return callAssert.AddFilter(reports => reports.Skip(1));
      }

      //-------------------------

      public static CallAssert ThatThrows<TException>(this CallAssert callOccurrence)
      {
         if (callOccurrence == null)
            throw new ArgumentNullException("callOccurrence");

         return callOccurrence.AddFilter(reports => reports.Where(x => x.Exception != null && x.Exception.GetType() == typeof(TException)));
      }

      public static CallAssert<TP1, TRet> ThatReturn<TP1, TRet>(this CallAssert<TP1, TRet> callAssert, TRet returnValue)
      {
         if (callAssert == null)
            throw new ArgumentNullException("callAssert");

         return callAssert.AddFilter(reports => reports.Where(x => Equals(x.ReturnValue, returnValue)));
      }
   }
}