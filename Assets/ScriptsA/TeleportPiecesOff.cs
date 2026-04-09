using UnityEngine;

public class TeleportPiecesOff : MonoBehaviour
{
    public Transform parentObject;
    public Vector3 offScreenPosition = new Vector3(10000f, 10000f, 0f);

    public void MoveOffScreen()
    {
        if (parentObject != null)
        {
            parentObject.position = offScreenPosition;
            Debug.Log("Parent moved off-screen");
        }
    }
}