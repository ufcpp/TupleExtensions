using System.Collections.Generic;

namespace TupleExtensions
{
    /// <summary>
    /// Extension methods for collections.
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// deconstructor for <see cref="KeyValuePair{TKey, TValue}"/>.
        /// </summary>
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> p, out TKey key, out TValue value)
        {
            key = p.Key;
            value = p.Value;
        }
    }
}
