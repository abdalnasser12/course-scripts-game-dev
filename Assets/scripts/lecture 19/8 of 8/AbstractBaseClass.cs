using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture19
{
    public abstract class AbstractBaseClass
    {
        public abstract void PerformAction();


        public void PrintInfo()
        {
            Debug.Log("This is a concrete method in the abstract base class.");
        }
    }
}