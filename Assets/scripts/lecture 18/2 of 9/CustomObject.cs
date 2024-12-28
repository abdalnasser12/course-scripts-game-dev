using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public class CustomObject
    {
        private int _id;
        private string _name;
        public int iid
        {
            get { return _id; }
            set { _id = value; }

        }
        public string nname
        {
            get { return _name; }
            set { _name = value; }
        }
        public CustomObject(int id, string name)
        {
            iid = id;
            nname = name;
        }
        public override string ToString()
        {
            return $"ID:{nname}, Name: {iid}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            CustomObject other = (CustomObject)obj;
            return this.iid == other.iid && this.nname == other.nname;

        }
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if (ReferenceEquals(obj1, null) && ReferenceEquals(obj2, null))
                return true;

            if (ReferenceEquals(obj1, null) || ReferenceEquals(obj2, null))
                return false;
            return obj1.iid == obj2.iid && obj1.nname == obj2.nname;
        }

        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return !(obj1 == obj2);
        }

    }
}