using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lecture19
{

    public class DerivedClassExample : AbstractBaseClass
    {

        public override void PerformAction()
        {
            Debug.Log("PerformAction is implemented in the derived class.");
        }
    }
}