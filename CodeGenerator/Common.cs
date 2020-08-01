﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CodeGenerator
{
    public static class Common
    {
        public static string GetClass(string text, int identationLevel, int spacesByTab = 4)
        {
            var identation = new string(' ', spacesByTab * identationLevel);

            return
@"using System;

namespace Curryfy
{
    //------------------------------------------------------------------------------ 
    // <auto-generated> 
    // This code was generated by a tool. 
    // 
    // Changes to this file may cause incorrect behavior and will be lost if 
    // the code is regenerated. 
    // </auto-generated> 
    //------------------------------------------------------------------------------

    public static partial class CurryfyExtensions
    { 
" +
    identation + text.Replace("\n", "\n" + identation)
+ @"
    }
}
";
        }

        public static void CreateFileInsideProject(string text, string fileName)
        {
            var dir = Directory.GetCurrentDirectory();
            dir = dir.Remove(dir.IndexOf(@"bin", StringComparison.InvariantCultureIgnoreCase));
            var path = Path.Combine(dir, fileName);

            path = path.Replace(Assembly.GetExecutingAssembly().GetName().Name, "Curry");

            var finalDir = Path.GetDirectoryName(path);

            if (!Directory.Exists(finalDir))
                Directory.CreateDirectory(finalDir);

            using (var tw = new StreamWriter(path, false))
            {
                tw.Write(text);
            }
        }


        public static TSource AggregateRight<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (func == null) throw new ArgumentNullException("func");
            if (!source.Any()) throw new InvalidOperationException("Sequence contains no elements");

            IList<TSource> e = (source as IList<TSource>) ?? source.ToArray();
            TSource current = e.Last();
            var i = e.Count - 1;

            while (i-- > 0)
            {
                current = func(e[i], current);
            }

            return current;
        }
    }
}
