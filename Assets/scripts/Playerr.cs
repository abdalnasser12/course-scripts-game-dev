using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class Playerr : Character
{
   
  
    public void Heal(int amount)
    {
         int heal = Health  + amount ;
        if(heal>100) 
        {
          heal = 100;
        }
        else if(heal<0)
        {
          heal = 0;
        }
        else
        {
           heal= Health + amount ;
        }
      Debug.Log(heal);
    }
    
    
}
