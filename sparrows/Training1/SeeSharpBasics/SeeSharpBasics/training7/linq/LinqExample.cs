using System;
using System.Collections;
using System.Collections.Generic;
using SeeSharpBasics.Test;

namespace SeeSharpBasics.training7.linq
{
    public static class LinqExample
    {
        public static IEnumerable<TSource> GhostRiderWhere<TSource>(this IEnumerable<TSource> obj, Func<TSource, bool> predicate)
        {
            List<TSource> resultList = new List<TSource>();
            foreach (var element in obj)
            {
                if (predicate(element))
                {
                    resultList.Add(element);
                }
            }

            return resultList;
        }
    }
}