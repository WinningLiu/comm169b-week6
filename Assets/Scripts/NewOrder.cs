using UnityEngine;
using UnityEngine.UI;

public class NewOrder : MonoBehaviour
{
    public Text Textfield;

    public void SetTest(string text)
    {
        Textfield.text = text;
    }
}
