using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public static class StringExtensions
    {
        public static string RepeatString(this string str, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += str;
            }
            return result;
        }
    }
}