using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
namespace lecture9
{


  public class Playerr : Character
  {


    public Playerr(string name, int health) : base(name, health)
    {

    }
    public void Heal(Playerr player, int amount)
    {
      int heal = player.Health + amount;
      if (heal > 100)
      {
        heal = 100;
      }
      else if (heal < 0)
      {
        heal = 0;
      }
      else
      {
        heal = player.Health + amount;
      }
      player.Health = heal;
      Debug.Log(heal);

    }
  }
}