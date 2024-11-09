using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture9
{


  public class Character
  {
    private string name;
    private int health;
    public string Name
    {
      get
      {
        return name;
      }
      set
      {
        name = value;
        Debug.Log(name);
      }
    }
    public int Health
    {
      get
      {
        return health;
      }
      set
      {
        if (health > 100)
        {
          health = 100;
        }
        else if (health < 0)
        {
          health = 0;
        }
        else
        {
          health = value;
        }
        Debug.Log(health);
      }
    }
    public Character(string name, int health)
    {
      this.Name = name;
      this.Health = health;
    }
  }
}