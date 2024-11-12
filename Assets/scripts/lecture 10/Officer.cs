using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture10
{


    public class Officer : Character
    {
        public Officer(string Name, int Health, Position positionn) : base(Name, Health, positionn)
        {

        }


        public override void Displayinfo()
        {
            base.Displayinfo();
            Debug.Log("officer");
        }
    }


}