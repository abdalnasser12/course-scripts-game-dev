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
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}