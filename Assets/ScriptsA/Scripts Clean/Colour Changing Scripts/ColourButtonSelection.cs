using UnityEngine;
using UnityEngine.UI;

public class PieceSelector : MonoBehaviour
{
    public static PieceSelector selectedPiece;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnPieceClick);
    }

    void OnPieceClick()
    {
        selectedPiece = this;
    }

    public void ChangeToSprite(Sprite newSprite)
    {
        GetComponent<Image>().sprite = newSprite;
    }
}