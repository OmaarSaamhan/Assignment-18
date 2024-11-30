using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18.Part1
{

    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> gameContainer = new GameContainer<string>();
            gameContainer.SetItem("Healing Potion");

            string item = gameContainer.GetItem();
            Debug.Log("Item: " + item);

            string description = GameUtils.DescribeItem(item);
            Debug.Log(description);
        }
    }
}
