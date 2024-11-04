using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player
{
   public string playerName = " ";
   public int health = 0 ;
   public static int playerCount= 0 ;
   
 public  void InilializePlayer(string name , int initialHealth)
   {
    playerName = name;
    health = initialHealth;
    Debug.Log(playerName+" "+ initialHealth);
   playerCount++;
   }
     
 public int Heal(int amount) 
   {
    int healthh= health + amount;
    if (healthh>100)
    {
      health=100;
    }
    else if (healthh< 0)
    {
     health = 0;
    }
    else
    {
      healthh = health + amount;
    }
   Debug.Log(healthh );
     return healthh;
   } 
   public void Heal(bool fullRestore)
   {
    if(fullRestore == true)
    {
     health = 100 ; 
     Debug.Log(health);
    }
    else
    {
      Debug.Log("health is full");
    }
   }
   
  public void ShowCount ()
  {
    Debug.Log(playerCount);
  }

  
   
}
