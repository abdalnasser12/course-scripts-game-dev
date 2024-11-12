using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
namespace lecture10
{


    public class Soldier : Character
    {
        public Soldier(string officerff, int Healthhhh, Position positionnnn) : base(officerff, Healthhhh, positionnnn)
        {

        }
        
        public override void Displayinfo()
        {
            base.Displayinfo();
            Debug.Log("soldier");
        }






    }
}
