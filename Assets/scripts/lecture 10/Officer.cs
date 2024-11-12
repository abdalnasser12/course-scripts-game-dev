using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture10
{


    public class Officer : Character
    {
        public Officer(string officerf, int Healthhh, Position positionnn) : base(officerf, Healthhh, positionnn)
        {

        }

        public override void Displayinfo()
        {
            base.Displayinfo();
            Debug.Log("officer");
        }
    }


}