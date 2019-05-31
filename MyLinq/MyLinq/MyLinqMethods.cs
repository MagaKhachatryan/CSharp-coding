using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq
{
    /// <summary>
    /// Static class that
    /// Represents custom extension linq methods implementation 
    /// </summary>
    public static class MyLinqMethods
    {
        #region SelectExt
        /// <summary>
        /// Projects each element of a sequence into a new form.
        /// parametrs:
        /// collection:
        /// Collection from which items must be chosen
        /// Condition:
        ///  A transform function to apply to each element.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="collection"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static IEnumerable<TResult> SelectExt<TSource, TResult>(this IEnumerable<TSource> collection, Func<TSource, TResult> predicate)
        {
            foreach (var item in collection)
            {
                yield return predicate(item);
            }
        }
        #endregion

        #region WhereExt
        /// <summary>
        /// WhereExt method filters elements from a collection based on a predicate
        /// parametrs:
        /// collection:
        /// Collection from which items must be chosen if it satisfies the predicate
        /// Condition:
        ///  A function to apply to each element.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="collection"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> WhereExt<TSource, TResult>(this IEnumerable<TSource> collection, Func<TSource, bool> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
        #endregion

        #region GroupByExt
        /// <summary>
        /// GroupByExtmethod groupsthe elements of a sequence according to 
        /// a specified key selector function.
        /// Parametrs:
        /// sourcce:
        /// Collection from which items must be chosen if it satisfies the predicate
        /// Condition:
        ///  A function to apply to each element.
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static IEnumerable<IGrouping<TKey, TSource>> GroupByExt<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {

            var dict = new Dictionary<TKey, List<TSource>>();
           
            foreach (var item in source)
            {
                var keyEx = keySelector(item);
                if (dict.ContainsKey(keyEx))
                {
                    dict[keyEx].Add(item);
                }
                else
                {
                    dict.Add(keyEx, new List<TSource> { item });
                }  
            }

            foreach(var item in dict)
            {
                yield return new Grouping<TKey, TSource>(item.Key, item.Value);
            }
        }
        #endregion

        #region ToListExt
        /// <summary>
        /// List<TSource> ToListExt method returrns collection as a list
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static List<TSource> ToListExt<TSource>(this IEnumerable<TSource> source)
        {
            var list = new List<TSource>();
            list.AddRange(source);
            return list;
           
        }
        #endregion

        #region ToDictionaryExt
        /// <summary>
        /// converts a collection into a dictionary according to a
        /// specified keyselector function
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static Dictionary<TKey, TSource> ToDictionaryExt<TKey, TSource>(this IEnumerable<TSource> source,Func<TSource,TKey> keySelector)
        {
            var dict = new Dictionary<TKey, TSource>();

            foreach (var item in source)
            {
                var key = keySelector(item);
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, item);
                }
            }
            return dict;
        }
        #endregion
    }
    #region OrderByExt
    IOrderedEnumerable<TSource> OrderByExt<TKey,TSource>(this IEnumerable<TSource> source,Func<TSource,TKey> keySelector)
    {

    }
    #endregion


    /// <summary>
    /// class implementing IGrouping
    /// for operating Group By method
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TSource"></typeparam>
    public class Grouping<TKey,TSource> : IGrouping<TKey, TSource>
    {
        private TKey key;
        private IEnumerable<TSource> list;

        public Grouping(TKey key,IEnumerable<TSource>  list)
        {
            this.key = key;
            this.list = list;
        }
        public TKey Key
        {
            get
            {
                return key;
            }
        }

        public IEnumerator<TSource> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }
    }

   
}
