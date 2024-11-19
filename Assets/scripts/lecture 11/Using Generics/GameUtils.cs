using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture11
{
    public class GameUtils
    {


        public static void DescribeItem<T>(GameContainer<T> something)
        {
            Debug.Log("this item is a"+ something.ReturnItem());

        }
    }


}
