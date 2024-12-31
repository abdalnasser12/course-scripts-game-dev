using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }

        public void Move()
        {
            Debug.Log("Animal moves.");
        }

    }
}