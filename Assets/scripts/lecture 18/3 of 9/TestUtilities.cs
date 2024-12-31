using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public class TestUtilities : MonoBehaviour
    {

        void Start()
        {
            int sum = Utilities.Add(1, 2, 3, 4, 5);
            Debug.Log("Sum of numbers: " + sum);

           
            string repeatedString = "Hello".RepeatString(3);
            Debug.Log("Repeated string: " + repeatedString);


        }
    }
}