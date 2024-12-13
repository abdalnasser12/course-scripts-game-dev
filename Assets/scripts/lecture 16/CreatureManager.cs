using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture16
{


    public class CreatureManager : MonoBehaviour
    {

        void Start()
        {
            List<Creature> creatures = new List<Creature> { new Kangaroo(), new Duck() };
            foreach (var creature in creatures)
            {

                creature.Speak();


                if (creature is IRunnable runnable)
                {
                    runnable.Run();
                }


                if (creature is IJumpable jumpable)
                {
                    jumpable.Jump();
                }


                if (creature is ISwimmable swimmable)
                {
                    swimmable.Swim();
                }
            }
        }



    }
}