using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture19
{
    public class BoxingUnboxing : MonoBehaviour
    {

        void Start()
        {

            int health = 100;


            object boxedHealth = health;


            int unboxedHealth = (int)boxedHealth;
            unboxedHealth += 50;


            print($"Original int value: {health}");
            print($"Boxed value: {boxedHealth}");
            print($"Unboxed and modified value: {unboxedHealth}");
        }



    }
}