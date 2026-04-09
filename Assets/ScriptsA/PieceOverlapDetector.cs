using UnityEngine;

public class UIOverlapAndParent : MonoBehaviour
{
    public RectTransform imageA;
    public RectTransform imageB;



    public void TryAttach()
    {
        if (IsOverlapping(imageA, imageB))
        {
            AttachBToA();
        }
        else
        {
            Debug.Log("Not overlapping");
        }
    }

    void AttachBToA()
    {
        // Set B as child of A
        imageB.SetParent(imageA);

        // Optional: keep its current visual position
        imageB.position = imageB.position;

        Debug.Log("Image B attached to Image A");
    }

    bool IsOverlapping(RectTransform a, RectTransform b)
    {
        Rect rectA = GetWorldRect(a);
        Rect rectB = GetWorldRect(b);

        return rectA.Overlaps(rectB);
    }

    Rect GetWorldRect(RectTransform rt)
    {
        Vector3[] corners = new Vector3[4];
        rt.GetWorldCorners(corners);

        Vector3 bottomLeft = corners[0];
        Vector3 topRight = corners[2];

        return new Rect(
            bottomLeft.x,
            bottomLeft.y,
            topRight.x - bottomLeft.x,
            topRight.y - bottomLeft.y
        );
    }
}