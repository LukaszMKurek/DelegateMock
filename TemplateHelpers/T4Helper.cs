using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplateHelpers
{
   public static class T4Helper
   {
      public static void From0To16(Action<Func<string, string>> action)
      {
         action(format => "");
         From1To16(action);
      }

      public static void From1To16(Action<Func<string, string>> action)
      {
         for (int i = 1; i <= 16; i++)
            action(format =>
            {
               format = format.Replace("#", "{0}");
               var formatedSequence = Enumerable.Range(1, i).Select(k => String.Format(format, k));
               return String.Join(", ", formatedSequence);
            });
      }

      public static string CAdd(this string self, string suffix)
      {
         return self.Length == 0 ? self : self + suffix;
      }

      public static string CWrap(this string self, string prefix, string suffix)
      {
         return self.Length == 0 ? self : prefix + self + suffix;
      }
   }
}
