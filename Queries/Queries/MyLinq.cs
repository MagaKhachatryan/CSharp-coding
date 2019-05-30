using System;
using System.Collections.Generic;

namespace Queries
{
    public static class MyLinq
    {
        public static int MyCount<TSource>(this IEnumerable<TSource> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count++;
            }
            return count;
        }

        public static IEnumerable<TResult> SelectExt<TSource, TResult>(this IEnumerable<TSource> collection, Func<TSource, TResult> predicate)
        {
            foreach (var item in collection)
            {
                yield return predicate(item);                
            }
        }
        
    }
}
