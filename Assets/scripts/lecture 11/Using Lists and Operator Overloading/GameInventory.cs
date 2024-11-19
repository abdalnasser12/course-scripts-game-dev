using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace lecture11
{


    public class GameInventory : MonoBehaviour
    {

        void Start()
        {
            Inventory potions = new Inventory();
            potions.AddItem("Healing Potion");
            potions.AddItem("Strength Potion");
            Inventory elixirs = new Inventory();
            elixirs.AddItem("Elixir");
            elixirs.AddItem("Dark Elixir");
            Inventory Summ;
            Summ = elixirs + potions;
            Summ.ShowItems();



        }


    }
}