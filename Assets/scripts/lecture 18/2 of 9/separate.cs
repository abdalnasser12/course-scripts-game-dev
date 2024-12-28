using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public class NewBehaviourScript : MonoBehaviour
    {

        void Start()
        {

            CustomObject obj1 = new CustomObject(1, "Example Object");
            print(obj1.ToString());


            CustomObject obj2 = new CustomObject(2, "Another Object");


            print($"Are obj1 and obj2 equal? {obj1 == obj2}");
            print($"Are obj1 and obj2 not equal? {obj1 != obj2}");
        }


    }
}