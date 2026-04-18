using UnityEngine;
using UnityEngine.UI;

public class Piece : MonoBehaviour
{
    public Sprite redSprite, yellowSprite, blueSprite;
    public static Piece selected;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => selected = this);
    }

    public void SetRed() { GetComponent<Image>().sprite = redSprite; }
    public void SetYellow() { GetComponent<Image>().sprite = yellowSprite; }
    public void SetBlue() { GetComponent<Image>().sprite = blueSprite; }
}