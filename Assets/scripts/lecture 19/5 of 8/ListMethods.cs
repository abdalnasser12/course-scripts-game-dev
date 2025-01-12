using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture19
{
    public class ListMethods : MonoBehaviour
    {
        void Start()
        {

            List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };


            List<int> filteredNumbers = numbers2.FindAll(number => number % 2 == 0);


            Debug.Log(string.Join(", ", filteredNumbers));
        }
    }
}