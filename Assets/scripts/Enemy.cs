using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public void Attack (int hit)
    {
        int hhit = Health - hit ;
         if(hhit>100) 
        {
          hhit = 100;
        }
        else if(hhit<0)
        {
          hhit = 0;
        }
        else
        {
           hhit = Health - hit ;
        }
        
        Debug.Log(hhit);
    }
    
    
}
