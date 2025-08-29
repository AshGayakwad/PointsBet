using System;
using System.Linq;

namespace PointsBet_Backend_Online_Code_Test
{
    public class StringFormatter
    {
        /// <summary>
        /// Returns a comma-separated string from the given array, with each item optionally quoted.
        /// </summary>
        /// <param name="items">The array of strings to join.</param>
        /// <param name="quote">The quote string to wrap each item with. If null, no quotes are used.</param>
        /// <returns>A comma-separated, optionally quoted string. Returns an empty string if items is null or empty.</returns>
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            if (items == null || items.Length == 0)
                return string.Empty;

            quote ??= string.Empty;

            // Optionally trim each item to avoid leading/trailing spaces
            return string.Join(", ", items.Select(item => $"{quote}{item?.Trim()}{quote}"));
        }
    }
}