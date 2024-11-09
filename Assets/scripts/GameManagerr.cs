using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManagerr : MonoBehaviour
{

    void Start()
    {
        Playerr abdalnasser = new Playerr("abdalnasser", 50);
        Enemy foad = new Enemy("foad", 100);

        foad.Attack(abdalnasser, 20);
        abdalnasser.Heal(abdalnasser, 10);






    }

}
