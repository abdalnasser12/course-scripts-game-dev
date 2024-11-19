using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
namespace lecture11
{


    public class Inventory
    {
        private List<string> list;
        public Inventory() { list = new List<string>(); }

        public string AddItem(string item)
        {
            list.Add(item);
            return item;
        }
        public void ShowItems()
        {
            foreach (string item in list)
            {
                Debug.Log(item);
            }
 ;
        }
        public static Inventory operator +(Inventory list2, Inventory list3)
        {

            Inventory list10 = new Inventory();
            foreach (string item in list2.list)
            {
                list10.list.Add(item);
            }
            foreach (string item in list3.list)
            {
                list10.list.Add(item);
            }

            return list10;


        }


    }
}