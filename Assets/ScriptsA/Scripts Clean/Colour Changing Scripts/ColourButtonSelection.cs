using UnityEngine;
using UnityEngine.UI;
public class ColourButtonSelection : MonoBehaviour
{
    public static ColourButtonSelection lastSelected; // keeps track of last clicked image
    private Image imageComponent;

    void Awake()
    {
        imageComponent = GetComponent<Image>();
    }

    // Call this method on click
    public void OnClick()
    {
        lastSelected = this;
    }

    // Change color of this image
    public void SetColor(Color newColor)
    {
        if (imageComponent != null)
        {
            imageComponent.color = newColor;
        }
    }
}
