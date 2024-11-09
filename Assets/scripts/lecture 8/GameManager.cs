using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture8
{


  public class GameManager : MonoBehaviour
  {
    // Start is called before the first frame update
    void Start()
    {
      Player abdalnasser = new Player();
      abdalnasser.InilializePlayer("abdalnasser", 50);
      abdalnasser.Heal(50);
      abdalnasser.Heal(true);
      abdalnasser.ShowCount();
      Player ahmad = new Player();
      ahmad.InilializePlayer("ahmed", 30);
      ahmad.Heal(50);
      ahmad.Heal(false);
      ahmad.ShowCount();



    }

    // Update is called once per frame
    void Update()
    {

    }
  }
}