using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public class Cat : Animal, ICanFight
    {

        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }


        public override void Move()
        {
            Debug.Log("Cat runs quickly.");
        }


        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }

}