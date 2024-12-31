using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {

            Cat myCat = new Cat();
            Animal upcastedAnimal = myCat;
            upcastedAnimal.MakeSound();
            upcastedAnimal.Move();

            // Downcasting
            Cat downcastedCat = upcastedAnimal as Cat;
            if (downcastedCat != null)
            {
                downcastedCat.MakeSound();
                downcastedCat.Move();
            }
            else
            {
                Debug.Log("Downcasting failed.");
            }


            List<ICanFight> fighters = new List<ICanFight>
        {
            new Cat(),
            new Warrior()
        };


            foreach (ICanFight fighter in fighters)
            {
                fighter.Attack();


                if (fighter is Cat)
                {
                    Debug.Log("The object is a Cat.");
                }
                else if (fighter is Warrior)
                {
                    Debug.Log("The object is a Warrior.");
                }
            }
        }

    }
}