using System.Collections.Generic;
using UnityEngine;

public class DetectPieceColisionandGlue : MonoBehaviour
{
    [Header("All pieces to check")]
    public List<RectTransform> pieces = new List<RectTransform>();

    // Call this from a button
    public void TryAttachChain()
    {
        if (pieces.Count < 2)
        {
            Debug.Log("Need at least 2 pieces to attach.");
            return;
        }

        // Track which pieces have been visited in the cluster
        HashSet<RectTransform> visited = new HashSet<RectTransform>();

        // Start DFS from the first piece
        ExploreCluster(pieces[0], visited);

        if (visited.Count == pieces.Count)
        {
            Debug.Log("All pieces are connected. Attaching...");
            AttachCluster();
        }
        else
        {
            Debug.Log("Pieces are not fully connected. Attach canceled.");
        }
    }

    // Recursively find all pieces connected via overlaps
    private void ExploreCluster(RectTransform piece, HashSet<RectTransform> visited)
    {
        if (visited.Contains(piece)) return;

        visited.Add(piece);

        foreach (RectTransform other in pieces)
        {
            if (other == piece) continue;
            if (visited.Contains(other)) continue;

            if (IsOverlapping(piece, other))
            {
                ExploreCluster(other, visited);
            }
        }
    }

    private void AttachCluster()
    {
        RectTransform parent = pieces[0];

        ParentPieceFlag state = parent.GetComponent<ParentPieceFlag>();
        if (state != null)
            state.isActive = true;

        for (int i = 1; i < pieces.Count; i++)
        {
            pieces[i].SetParent(parent);
            pieces[i].position = pieces[i].position; // keep visual position
            Debug.Log($"{pieces[i].name} attached to {parent.name}");
        }
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