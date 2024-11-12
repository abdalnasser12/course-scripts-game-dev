using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lecture10
{


    public class CharacterTest : MonoBehaviour
    {





        void Start()
        {
            Character[] characters = new Character[2];
            Soldier soldier = new Soldier("abdalnasser", 100, new Position(1, 5, 6));
            Officer officer = new Officer("ahmed", 100, new Position(1, 6, 7));
            characters[0] = soldier;
            characters[1] = officer;
            for (int i = 0; i > characters.Length; i++)
            {
              characters[i].Displayinfo() ;
            }
            Soldier soldierr = characters[0];
            Officer officerr = characters[1];
            Debug.Log(soldierr.Health);
            officerr.Attack(10, soldierr, "shoot");
            Debug.Log(soldierr.Health);


        }


    }

}
