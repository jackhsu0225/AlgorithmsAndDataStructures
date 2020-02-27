﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    /// <summary>
    /// First Attempt
    /// Note:
    ///     [1] Convert input string to char array is already O(n)
    ///     [2] Checking whether the input string is odd or even in length is redundant.
    /// </summary>
    public class StringUtils
    {
        public string ReverseString(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var arr = input.ToCharArray();
            var center = arr.Length / 2;
            var last = arr.Length - 1;

            if(center % 2 == 0)
            {
                for (int i = 0; i < center; i++)
                {
                    var temp = arr[i];
                    arr[i] = arr[last];
                    arr[last] = temp;
                    
                    last--;
                }
            }
            else
            {
                for (int i = 0; i <= center; i++)
                {
                    var temp = arr[i];
                    arr[i] = arr[last];
                    arr[last] = temp;

                    last--;
                }
            }

            return new string(arr);
        }

        /// <summary>
        /// This method traverse from the head of input string until the middle of the input string.
        /// In each traversal, the first and the last char are saved in the char array.
        /// Pro: 
        ///     Only needs to traverse to the middle point of the input string. O(n/2)
        ///     
        /// References:
        ///     [1] string VS String: https://programmingwithmosh.com/net/difference-between-string-and-string-in-c/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseString2(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var last = input.Length - 1;
            var reversed = new char[input.Length];

            for(int i = 0; i <= (input.Length - 1) / 2; i++)
            {
                reversed[i] = input[last];
                reversed[last] = input[i];
                last--;
            }

            return new string(reversed);
        }

        /// <summary>
        /// This method reads from the tail to head of the input string, and append each char to a StringBuilder.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseString3(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var last = input.Length - 1;
            var sb = new StringBuilder(input.Length); //Initialize a StringBuilder with the initial capacity equal to input.Length

            for(int i = last; i >= 0; i--)
                sb.Append(input[i]);

            return sb.ToString();
        }

        /// <summary>
        /// This method uses a hashset to store vowels and iterate through the input string to find vowels.
        /// 
        /// References:
        /// [1] 5 C# Collections that every C# Developer Must Know https://programmingwithmosh.com/net/csharp-collections/
        /// [2] HashTable vs Dictionary: https://www.geeksforgeeks.org/difference-between-hashtable-and-dictionary-in-c-sharp/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int CountVowels(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return 0;

            var count = 0;
            var vowelsSet = new HashSet<char>()
            {
                'a',
                'e',
                'i',
                'o',
                'u',
            };

            foreach(var i in input.ToLower())
            {
                if (vowelsSet.Contains(i))
                    count++;
            }

            return count;
        }

        /// <summary>
        /// This method split the input string by a delimiter and iterate through the array from the tail to the head.
        /// During the iteration, each string is added to the StringBuilder.
        /// References:
        /// [1] https://www.geeksforgeeks.org/collections-in-c-sharp/
        /// [2] https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseWords(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var words = input.Trim().Split(new char[] { ' ' });
            var sb = new StringBuilder(input.Length);
            for(int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i]);
                if(i != 0) //Instead of doing this, we can also use TrimEnd().
                    sb.Append(" ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// This method split the input string by a delmiter, and uses the Array utility method to reverse the array.
        /// Once the array is reversed, it uses the Join method to concatenate each string.
        /// References:
        /// [1] https://www.geeksforgeeks.org/c-sharp-arrays/
        /// [2] https://www.geeksforgeeks.org/c-sharp-array-class/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ReverseWords2(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return String.Empty;

            var words = input.Trim().Split(new char[] { ' ' });
            Array.Reverse(words);
            
            return String.Join(" ", words);
        }

        public bool AreRotations(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;
            if (str1.Length != str2.Length)
                return false;

            if (!(str1 + str1).Contains(str2))
                return false;

            return true;
        }

        /// <summary>
        /// This method removes duplicate char of the input string by 
        /// iterating through the string and check if the current char is in the set.
        /// None duplicate char are saved to the set and the StringBuilder.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RemoveDuplicates(string str)
        {
            if (String.IsNullOrEmpty(str))
                return String.Empty;

            var seen = new HashSet<char>();
            var sb = new StringBuilder(str.Length);

            foreach(var s in str)
            {
                if (!seen.Contains(s))
                {
                    seen.Add(s);
                    sb.Append(s);
                }
            }

            return sb.ToString();
        }
    }
}
