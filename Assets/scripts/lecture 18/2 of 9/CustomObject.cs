using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture18
{
    public class CustomObject
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public CustomObject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            CustomObject other = (CustomObject)obj;
            return this.Id == other.Id && this.Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name.GetHashCode();
        }

        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {

            if (obj1 == null && obj2 == null)
                return true;


            if (obj1 == null || obj2 == null)
                return false;


            return obj1.Id == obj2.Id && obj1.Name == obj2.Name;
        }

        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return !(obj1 == obj2);
        }

    }
}