using System.Linq;
using System.Collections.Generic;
using System;
using DelegateMock.FunctionStub;

namespace DelegateMock.Implementation
{
// ReSharper disable RedundantLambdaSignatureParentheses
   public static class MockExtension
   {
      public static Func<TRet> Func<TRet>(this Mock self, Node<TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TRet> Func<TRet>(this Mock self, Func<TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TRet> wrapDelegateTemp = null;
         Func<TRet> wrapDelegate = () =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func();
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action Action(this Mock self, Action action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action wrapDelegateTemp = null;
         Action wrapDelegate = () =>
         {
            Exception exception = null;

            try
            {
               action();
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TRet> Func<TP1, TRet>(this Mock self, Node<TP1, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TRet> Func<TP1, TRet>(this Mock self, Func<TP1, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TRet> wrapDelegateTemp = null;
         Func<TP1, TRet> wrapDelegate = (p1) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1> Action<TP1>(this Mock self, Action<TP1> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1> wrapDelegateTemp = null;
         Action<TP1> wrapDelegate = (p1) =>
         {
            Exception exception = null;

            try
            {
               action(p1);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TRet> Func<TP1, TP2, TRet>(this Mock self, Node<TP1, TP2, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TRet> Func<TP1, TP2, TRet>(this Mock self, Func<TP1, TP2, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TRet> wrapDelegate = (p1, p2) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2> Action<TP1, TP2>(this Mock self, Action<TP1, TP2> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2> wrapDelegateTemp = null;
         Action<TP1, TP2> wrapDelegate = (p1, p2) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TRet> Func<TP1, TP2, TP3, TRet>(this Mock self, Node<TP1, TP2, TP3, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TRet> Func<TP1, TP2, TP3, TRet>(this Mock self, Func<TP1, TP2, TP3, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TRet> wrapDelegate = (p1, p2, p3) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3> Action<TP1, TP2, TP3>(this Mock self, Action<TP1, TP2, TP3> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3> wrapDelegate = (p1, p2, p3) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TRet> Func<TP1, TP2, TP3, TP4, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TRet> Func<TP1, TP2, TP3, TP4, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TRet> wrapDelegate = (p1, p2, p3, p4) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4> Action<TP1, TP2, TP3, TP4>(this Mock self, Action<TP1, TP2, TP3, TP4> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4> wrapDelegate = (p1, p2, p3, p4) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TRet> Func<TP1, TP2, TP3, TP4, TP5, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TRet> Func<TP1, TP2, TP3, TP4, TP5, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TRet> wrapDelegate = (p1, p2, p3, p4, p5) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5> Action<TP1, TP2, TP3, TP4, TP5>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5> wrapDelegate = (p1, p2, p3, p4, p5) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6> Action<TP1, TP2, TP3, TP4, TP5, TP6>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6> wrapDelegate = (p1, p2, p3, p4, p5, p6) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7, p8);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7, p8);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7, p8, p9);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this Mock self, Node<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> node)
      {
         if (node == null)
            throw new ArgumentNullException("node");

         return self.Func(node.AsFunc());
      }

      public static Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet>(this Mock self, Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> func)
      {
         if (func == null)
            throw new ArgumentNullException("func");

         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> wrapDelegateTemp = null;
         Func<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16, TRet> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) =>
         {
            TRet returnValue = default(TRet);
            Exception exception = null;

            try
            {
               returnValue = func(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
               return returnValue;
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16), returnValue, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }

      public static Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16>(this Mock self, Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> action)
      {
         if (action == null)
            throw new ArgumentNullException("action");

         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> wrapDelegateTemp = null;
         Action<TP1, TP2, TP3, TP4, TP5, TP6, TP7, TP8, TP9, TP10, TP11, TP12, TP13, TP14, TP15, TP16> wrapDelegate = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) =>
         {
            Exception exception = null;

            try
            {
               action(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
            }
            catch (Exception ex)
            {
               exception = ex;
               throw;
            }
            finally
            {
               // ReSharper disable AccessToModifiedClosure
               self.ReportCall(wrapDelegateTemp, ImmutableArray<object>.New(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16), null, exception);
               // ReSharper restore AccessToModifiedClosure
            }
         };

         wrapDelegateTemp = wrapDelegate;
         return wrapDelegate;
      }
      //-----------------------------------------------------------------------------------------------------------

   }
// ReSharper enable RedundantLambdaSignatureParentheses
}
