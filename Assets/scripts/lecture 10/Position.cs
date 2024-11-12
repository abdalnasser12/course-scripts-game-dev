using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
namespace lecture10
{


    public struct Position
    {
        public float x;
        public float y;
        public float z;
        public Position(float X, float Y, float Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }
        public void PrintPosition()
        {
            Debug.Log($"{x} ; {y} ; {z}");
        }


    }
}