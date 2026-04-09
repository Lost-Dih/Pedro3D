using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public Color buttonColor; // set this in the inspector

    public void ChangeSelectedColor()
    {
        if (ColourButtonSelection.lastSelected != null)
        {
            ColourButtonSelection.lastSelected.SetColor(buttonColor);
        }
    }
}
