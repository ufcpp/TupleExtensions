using System;
using System.Collections.Generic;

namespace TupleExtensions
{
    /// <summary>
    /// Extension methods for <see cref="ValueTuple"/>.
    /// </summary>
    public static class ValueTupleExtensions
    {
        /// <summary>
        /// Nearly equivalent to <![CDATA[ items.Select((x, i) => (item: x, index: i)) ]]>.
        /// </summary>
        /// <typeparam name="T">type of elements.</typeparam>
        /// <param name="items">A sequence of values.</param>
        /// <returns>An indexed sequence.</returns>
        public static IEnumerable<(T item, int index)> Indexed<T>(this IEnumerable<T> items)
        {
            if (items == null) new ArgumentNullException(nameof(items));
            return inner();

            IEnumerable<(T item, int index)> inner()
            {
                var index = 0;
                foreach (var item in items)
                {
                    yield return (item, index);
                }
            }
        }
    }
}
