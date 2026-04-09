using System.Collections.Generic;
using UnityEngine;

public class CheckDeletedObjects : MonoBehaviour
{
    [Header("Objects to Check (3 total)")]
    public GameObject[] trackedObjects = new GameObject[3];

    [Header("If 1 Object Deleted")]
    public List<GameObject> enableIf1;
    public List<GameObject> disableIf1;

    [Header("If 2 Objects Deleted")]
    public List<GameObject> enableIf2;
    public List<GameObject> disableIf2;

    public void OnButtonPressed()
    {
        int deletedCount = 0;

        foreach (GameObject obj in trackedObjects)
        {
            if (obj == null)
            {
                deletedCount++;
            }
        }

        Debug.Log("Deleted objects: " + deletedCount);

        if (deletedCount == 1)
        {
            SetActiveList(enableIf1, true);
            SetActiveList(disableIf1, false);
        }
        else if (deletedCount == 2)
        {
            SetActiveList(enableIf2, true);
            SetActiveList(disableIf2, false);
        }
        else
        {
            Debug.Log("No action for this amount.");
        }
    }

    void SetActiveList(List<GameObject> list, bool state)
    {
        foreach (GameObject obj in list)
        {
            if (obj != null)
            {
                obj.SetActive(state);
            }
        }
    }
}
