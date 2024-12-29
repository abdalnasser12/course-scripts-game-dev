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
            var oddOrEven = number % 2 == 0 ? word2 : word1;
            Debug.Log($"{number} is {oddOrEven}");
            Debug.Log($"{System.DateTime.Now} : {System.DateTime.Now.DayOfWeek}");
        }

    }
}