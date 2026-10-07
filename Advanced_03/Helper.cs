using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_03
{
    internal class Helper
    {
        public static void PrintList<T>(string listname,List<T> list)
        {
            Console.WriteLine($"{listname}: {string.Join(", ", list)}");
        }
        public static void PrintSortedList<TKey, TValue>(string listname, SortedList<TKey, TValue> sortedList)
        {
            Console.WriteLine($"{listname}:");
            foreach (var entry in sortedList)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}
