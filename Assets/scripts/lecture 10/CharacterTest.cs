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
            Soldier soldier = new Soldier("abdalnasser", 10, new Position(1, 5, 6));
            Officer officer = new Officer("ahmed", 190, new Position(1, 6, 7));
            characters[0] = soldier;
            characters[1] = officer;
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].Displayinfo();
            }



            Debug.Log(characters[0].Health);
            officer.Attack(5, characters[0], "fire ball");



        }


    }

}
