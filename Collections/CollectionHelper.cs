﻿using System.Collections.Generic;

namespace Jaywapp.Infrastructure.Collections
{
    public static class CollectionHelper
    {
        /// <summary>
        /// <paramref name="collection"/>에 <paramref name="items"/>를 추가합니다.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="items"></param>
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            foreach (var item in items)
                collection.Add(item);
        }
    }
}
