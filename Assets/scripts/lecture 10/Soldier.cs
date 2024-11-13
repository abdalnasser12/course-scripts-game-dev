using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
namespace lecture10
{


    public class Soldier : Character
    {
        public Soldier(string Name, int Health, Position positionn) : base(Name, Health, positionn)
        {

        }
        public Soldier() : base()
        {

        }

        public override void Displayinfo()
        {
            base.Displayinfo();
            Debug.Log("soldier");
        }






    }
}
