using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18.Part2
{

    public class Inventory
    {
        private List<string> names = new List<string>();

        public void AddItem(string item)
        {
            names.Add(item);
        }

        public void ShowItems()
        {
            foreach (string n in names)
            {
                Debug.Log(n);
            }
        }

        public static Inventory operator + (Inventory a, Inventory b)
        {
            Inventory inventory = new Inventory();
            inventory.names.AddRange(a.names);
            inventory.names.AddRange(b.names);

            return inventory;
            
        }
    }
}