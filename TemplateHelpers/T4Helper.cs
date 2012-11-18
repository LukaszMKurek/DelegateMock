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
            int ii = i;
            action(i, (s1, s2, s3) => // eventualy use one parameter where string separator is sign ' 
            {
               string format = s3 == null ? s1 : s2;
               string prefix = s3 == null ? "" : s1;
               string suffix = s3 ?? (s2 ?? "");

               format = format.Replace("#", "{0}");
               var formatedSequence = Enumerable.Range(1, ii).Select(k => String.Format(format, k));
               return String.Join(", ", formatedSequence).CWrap(prefix, suffix);
            });
         }
      }

      private static string CWrap(this string self, string prefix, string suffix)
      {
         return self.Length == 0 ? self : prefix + self + suffix;
      }
   }
}
