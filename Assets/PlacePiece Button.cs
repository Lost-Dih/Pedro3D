using UnityEngine;

public class MoveUIToButton : MonoBehaviour
{
    public RectTransform parentImage; // the parent Raw Image
    public RectTransform buttonTransform; // the button

    public void MoveToButton()
    {
        parentImage.position = buttonTransform.position;
    }
}
