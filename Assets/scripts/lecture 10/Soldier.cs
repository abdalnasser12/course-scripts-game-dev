using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
namespace lecture10
{


    public abstract class Soldier : Character
    {
        public Soldier(string Soldier, int Healthh, Position position) : base(Soldier, Healthh, new Position(0, 0, 0))
        {

        }

        public override void Displayinfo()
        {
            base.Displayinfo();
            Debug.Log("soldier");
        }






    }
}
