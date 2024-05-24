using System;
using System.Collections.Generic;
using System.Linq;

namespace prove_05
{
    public static class SetTests
    {
        public static void Run()
        {
            Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
            var s1 = new HashSet<int>(new[] { 1, 2, 3, 4, 5 });
            var s2 = new HashSet<int>(new[] { 4, 5, 6, 7, 8 });
            Console.WriteLine(Intersection(s1, s2).AsString()); // <Set>{4, 5}
            Console.WriteLine(Union(s1, s2).AsString()); // <Set>{1, 2, 3, 4, 5, 6, 7, 8}
            Console.WriteLine("---------");

            s1 = new HashSet<int>(new[] { 1, 2, 3, 4, 5 });
            s2 = new HashSet<int>(new[] { 6, 7, 8, 9, 10 });
            Console.WriteLine(Intersection(s1, s2).AsString()); // <Set>{}
            Console.WriteLine(Union(s1, s2).AsString()); // <Set>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

            Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
            DisplayPairs(new[] { "am", "at", "ma", "if", "fi" });
            // ma & am
            // fi & if
            Console.WriteLine("---------");
            DisplayPairs(new[] { "ab", "bc", "cd", "de", "ba" });
            // ba & ab
            Console.WriteLine("---------");
            DisplayPairs(new[] { "ab", "ba", "ac", "ad", "da", "ca" });
            // ba & ab
            // da & ad
            // ca & ac
            Console.WriteLine("---------");
            DisplayPairs(new[] { "ab", "ac" }); // No pairs displayed
            Console.WriteLine("---------");
            DisplayPairs(new[] { "ab", "aa", "ba" });
            // ba & ab
            Console.WriteLine("---------");
            DisplayPairs(new[] { "23", "84", "49", "13", "32", "46", "91", "99", "94", "31", "57", "14" });
            // 32 & 23
            // 94 & 49
            // 31 & 13
        }

        private static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
        {
            var result = new HashSet<int>();
            // Loop through elements of set1
            foreach (var item in set1)
            {
                // Check if the element exists in set2
                if (set2.Contains(item))
                {
                    // If it does, add it to the result set
                    result.Add(item);
                }
            }
            return result;
        }

        private static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
        {
            var result = new HashSet<int>();
            // Add all elements of set1 to the result set
            foreach (var item in set1)
            {
                result.Add(item);
            }
            // Add all elements of set2 to the result set
            foreach (var item in set2)
            {
                result.Add(item);
            }
            return result;
        }

        private static void DisplayPairs(string[] words)
        {
            // Create a set to store processed words
            var processed = new HashSet<string>();
            // Loop through each word
            foreach (var word in words)
            {
                // Reverse the word
                var reverseWord = new string(word.Reverse().ToArray());
                // Check if the reversed word exists in the set
                if (processed.Contains(reverseWord))
                {
                    // If it does, display the pair
                    Console.WriteLine($"{word} & {reverseWord}");
                }
                // Add the word to the processed set
                processed.Add(word);
            }
        }
    }
}