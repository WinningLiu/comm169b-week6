using UnityEngine;
using UnityEngine.UI;
using System;

public class NewOrder : MonoBehaviour
{
    public Text Textfield;

    public void SetTest()
    {
        string text = "";
        string[] ingredients = { "Corn Flakes", "Watermelon", "Apple", "Lemon", "Sauce", "Milk" };
        var rnd = new System.Random();
        for (int i = 0; i < 6; i++)
        {
            if (rnd.Next(1) == 1)
            {
                text += ingredients[i] + ", ";
            }
        }
        Textfield.text = text;
    }
}
