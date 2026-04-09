using UnityEngine;

public class MoveUIToButton : MonoBehaviour
{
    public RectTransform parentImage; // the parent Raw Image
    public RectTransform buttonTransform; // the button
    public Vector3 targetScale = Vector3.one;

    public void MoveToButton()
    {
        parentImage.position = buttonTransform.position;
        parentImage.localScale = targetScale;
    }
}
