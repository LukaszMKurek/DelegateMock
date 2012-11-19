using System.Linq;
using System.Collections.Generic;
using System;

namespace DelegateMock.Implementation
{
   public static class PublicActionCallConstraintExtension
   {
      public static ActionCallConstraint WithArgs(this Action action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint)action, arguments);
      }

      public static ActionCallConstraint WithArgs(this ActionCallConstraint actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint WithArgs(this Action action, Func<bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint)action, argsFilter);
      }

      public static ActionCallConstraint WithArgs(this ActionCallConstraint actionCallConstraint, Func<bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint SecondCall(this Action action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint)action);
      }

      public static ActionCallConstraint SecondCall(this ActionCallConstraint actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

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
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2> WithArgs<TP1, TP2>(this Action<TP1, TP2> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2> WithArgs<TP1, TP2>(this ActionCallConstraint<TP1, TP2> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2> WithArgs<TP1, TP2>(this Action<TP1, TP2> action, Func<TP1, TP2, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2> WithArgs<TP1, TP2>(this ActionCallConstraint<TP1, TP2> actionCallConstraint, Func<TP1, TP2, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2> SecondCall<TP1, TP2>(this Action<TP1, TP2> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2>)action);
      }

      public static ActionCallConstraint<TP1, TP2> SecondCall<TP1, TP2>(this ActionCallConstraint<TP1, TP2> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3> WithArgs<TP1, TP2, TP3>(this Action<TP1, TP2, TP3> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3> WithArgs<TP1, TP2, TP3>(this ActionCallConstraint<TP1, TP2, TP3> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3> WithArgs<TP1, TP2, TP3>(this Action<TP1, TP2, TP3> action, Func<TP1, TP2, TP3, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3> WithArgs<TP1, TP2, TP3>(this ActionCallConstraint<TP1, TP2, TP3> actionCallConstraint, Func<TP1, TP2, TP3, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3> SecondCall<TP1, TP2, TP3>(this Action<TP1, TP2, TP3> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3> SecondCall<TP1, TP2, TP3>(this ActionCallConstraint<TP1, TP2, TP3> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4> WithArgs<TP1, TP2, TP3, TP4>(this Action<TP1, TP2, TP3, TP4> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4> WithArgs<TP1, TP2, TP3, TP4>(this ActionCallConstraint<TP1, TP2, TP3, TP4> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4> WithArgs<TP1, TP2, TP3, TP4>(this Action<TP1, TP2, TP3, TP4> action, Func<TP1, TP2, TP3, TP4, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4> WithArgs<TP1, TP2, TP3, TP4>(this ActionCallConstraint<TP1, TP2, TP3, TP4> actionCallConstraint, Func<TP1, TP2, TP3, TP4, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4> SecondCall<TP1, TP2, TP3, TP4>(this Action<TP1, TP2, TP3, TP4> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4> SecondCall<TP1, TP2, TP3, TP4>(this ActionCallConstraint<TP1, TP2, TP3, TP4> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> WithArgs<TP1, TP2, TP3, TP4, TP5>(this Action<TP1, TP2, TP3, TP4, TP5> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> WithArgs<TP1, TP2, TP3, TP4, TP5>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> WithArgs<TP1, TP2, TP3, TP4, TP5>(this Action<TP1, TP2, TP3, TP4, TP5> action, Func<TP1, TP2, TP3, TP4, TP5, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> WithArgs<TP1, TP2, TP3, TP4, TP5>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> SecondCall<TP1, TP2, TP3, TP4, TP5>(this Action<TP1, TP2, TP3, TP4, TP5> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> SecondCall<TP1, TP2, TP3, TP4, TP5>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6>(this Action<TP1, TP2, TP3, TP4, TP5, TP6> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6>(this Action<TP1, TP2, TP3, TP4, TP5, TP6> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6>(this Action<TP1, TP2, TP3, TP4, TP5, TP6> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> action, params object[] arguments)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (arguments == null)
            throw new ArgumentNullException("arguments");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>)action, arguments);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> actionCallConstraint, params object[] arguments)
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
      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> action, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> argsFilter)
      {
         if (action == null)
            throw new ArgumentNullException("action");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return WithArgs((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>)action, argsFilter);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> WithArgs<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> actionCallConstraint, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, bool> argsFilter)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");
         if (argsFilter == null)
            throw new ArgumentNullException("argsFilter");

         return actionCallConstraint.AddFilter(reports => reports.Where(x => (bool)argsFilter.DynamicInvoke(x.Arguments.ToArray())));
      }

      //-----------------------

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(this Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         return SecondCall((ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>)action);
      }

      public static ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> SecondCall<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(this ActionCallConstraint<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> actionCallConstraint)
      {
         if (actionCallConstraint == null)
            throw new ArgumentNullException("actionCallConstraint");

         return actionCallConstraint.AddFilter(reports => reports.Skip(1));
      }
      //--------------------------------------------------------------------------------------------------------------

   }
}
