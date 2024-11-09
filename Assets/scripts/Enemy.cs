using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
  public Enemy(string name, int health) : base(name, health)
  {

  }
  public void Attack(Playerr player, int hit)
  {
    int hhit = player.Health - hit;
    if (hhit > 100)
    {
      hhit = 100;
    }
    else if (hhit < 0)
    {
      hhit = 0;
    }
    else
    {
      hhit = player.Health - hit;
    }
    player.Health = hhit;
    Debug.Log(hhit);

  }
}
