using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PiecePattern : MonoBehaviour, IPointerClickHandler
{
    public Sprite redSprite, yellowSprite, blueSprite;
    public static PiecePattern selected;

    void Start()
    {
        // Auto-detect clicks on Image - NO Button needed
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        selected = this;
        Debug.Log("Selected: " + name);
    }

    public void SetRed()
    {
        var img = GetComponent<Image>();
        if (img != null && selected == this)
            img.sprite = redSprite;
    }

    public void SetYellow()
    {
        var img = GetComponent<Image>();
        if (img != null && selected == this)
            img.sprite = yellowSprite;
    }

    public void SetBlue()
    {
        var img = GetComponent<Image>();
        if (img != null && selected == this)
            img.sprite = blueSprite;
    }
}