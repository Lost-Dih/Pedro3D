using UnityEngine;

public class TeleportActivePieces : MonoBehaviour
{
    public Vector3 offscreenPosition = new Vector3(-1000, -1000, 0); // position offscreen

    // Call this method to teleport all active pieces
    public void TeleportActive()
    {
        // Find all ParentPieceFlag scripts in the scene
        ParentPieceFlag[] allPieces = FindObjectsOfType<ParentPieceFlag>();

        foreach (ParentPieceFlag piece in allPieces)
        {
            if (piece.isActive)
            {
                piece.transform.position = offscreenPosition;
            }
        }
    }
}