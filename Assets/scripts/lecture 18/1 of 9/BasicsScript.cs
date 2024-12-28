using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public class BasicsScript : MonoBehaviour
    {

        void Start()
        {
            var number = 1;
            var word1 = "odd";
            var word2 = "even";
            var trueorfalse = true;
            var oddOrEven = number % 2 == 0 ? word1 : word2;
            Debug.Log($"{number} is {oddOrEven}");
            Debug.Log($"{System.DateTime.Now} : {System.DateTime.Now.DayOfWeek}");

        }

    }
}