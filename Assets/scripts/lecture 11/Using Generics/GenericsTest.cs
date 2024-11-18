using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace lecture11
{
    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameContainer<string> Game = new GameContainer<string>();
            Game.SaveIitem("Healing Potion");
            Debug.Log($"{GameUtils.DescribeItem("This item is")} {Game.ReturnItem()}");

        }
    }
}