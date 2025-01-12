
using System;
using UnityEngine;
namespace lecture19
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        void Start()
        {

            Action logMessage = () => Debug.Log("Hello from Action delegate!");
            logMessage();


            Func<int, int> square = number => number * number;
            Debug.Log($"Square: {square(5)}");


            Predicate<int> isEven = number => number % 2 == 0;
            Debug.Log($"Is 4 even? {isEven(4)}");
        }
    }
}