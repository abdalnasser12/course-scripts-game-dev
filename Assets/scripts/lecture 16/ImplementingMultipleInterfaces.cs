using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture16
{


    public class ImplementingMultipleInterfaces
    {
    }
    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }
        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }

    }
    public class Duck : Creature, IRunnable, ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }
}