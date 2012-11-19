using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplateHelpers
{
   public static class T4Helper
   {
      public delegate string ForEach(string s1, string s2 = null, string s3 = null);

      public static void ForEachInRange(int from, int to, Action<int, ForEach> action)
      {
         for (int i = from; i <= to; i++)
         {
            int multiplier = i;
            action(i, (s1, s2, s3) => // eventualy use one parameter where string separator is sign ' 
            {
               if (s3 == null)
                  return Compile("", s1, s2 ?? "", multiplier);

               return Compile(s1 ?? "", s2, s3, multiplier);
            });
         }
      }

      private static string Compile(string prefix, string format, string suffix, int multiplier)
      {
         if (format == null)
            throw new ArgumentNullException("format");

         format = format.Replace("#", "{0}");
         var formatedSequence = Enumerable.Range(1, multiplier).Select(k => String.Format(format, k));
         return String.Join(", ", formatedSequence).CWrap(prefix, suffix);
      }

      private static string CWrap(this string self, string prefix, string suffix)
      {
         return self.Length == 0 ? self : prefix + self + suffix;
      }
   }
}
