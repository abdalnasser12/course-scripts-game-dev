using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture16
{


    public class Base
    {
    }
    public class Creature
    {


        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }
}