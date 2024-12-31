using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }


        public static string RepeatString(this string str, int count)
        {
            if (count <= 0) return string.Empty;

            return new string(' ', count).Replace(" ", str);
        }
    }
}