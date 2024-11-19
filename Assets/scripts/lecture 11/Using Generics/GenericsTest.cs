using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace lecture11
{
    public class GenericsTest : MonoBehaviour
    {

        void Start()
        {
            GameContainer<string> Game = new GameContainer<string>();
            Game.SaveIitem("Healing Potion");
            Debug.Log($"{GameUtils.DescribeItem("This item is")} {Game.ReturnItem()}");

        }
    }
}