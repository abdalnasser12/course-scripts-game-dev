using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture11
{
    public class GameContainer<T>
    {
        T item;
        public void SaveIitem(T iitem)
        {
            item = iitem;
            Debug.Log(item);

        }
        public T ReturnItem()
        {
            return item;
        }

    }
}