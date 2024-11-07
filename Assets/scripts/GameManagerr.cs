using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManagerr : MonoBehaviour
{
    
    void Start()
    {
       Playerr abdalnasser = new Playerr(); 
       Playerr ahmed = new Playerr();
       Enemy foad = new Enemy();
       
       abdalnasser.Name ="abdalnasser";
       foad.Name = "Foad";
       abdalnasser.Health = 10;
       foad.Health = 100;
       
       
       abdalnasser.Heal(50);
       foad.Attack(10);
       
    
    }

}
