using UnityEngine;

public class MoveActiveUIToButton : MonoBehaviour
{
    public Vector3 targetScale = Vector3.one; // optional scale when moved

    // Call this when a button is clicked
    public void MoveActiveToButton(RectTransform buttonTransform)
    {
        // Find the first active image in the scene
        ParentPieceFlag[] allPieces = FindObjectsOfType<ParentPieceFlag>();
        foreach (ParentPieceFlag piece in allPieces)
        {
            if (piece.isActive)
            {
                RectTransform rt = piece.GetComponent<RectTransform>();
                if (rt != null)
                {
                    rt.position = buttonTransform.position;
                    rt.localScale = targetScale;
                }

                // Turn off isActive so this piece won't be moved again
                piece.isActive = false;

                break; // move only the first active piece
            }
        }
    }
}