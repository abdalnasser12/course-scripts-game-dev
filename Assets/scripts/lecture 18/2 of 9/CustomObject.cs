using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lecture18
{
    public class CustomObject
    {



        public int ID { get; set; }
        public string Name { get; set; }


        public CustomObject(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }




        public override bool Equals(object obj)
        {
            if (obj is CustomObject other)
            {
                return this.ID == other.ID && this.Name == other.Name;
            }
            return false;
        }




        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            return obj1.Equals(obj2);
        }

        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return !obj1.Equals(obj2);
        }

    }

}

