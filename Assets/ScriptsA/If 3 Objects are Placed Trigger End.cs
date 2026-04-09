using UnityEngine;

public class If3ObjectsarePlacedTriggerEnd : MonoBehaviour
{
    [Header("Objects to check if destroyed")]
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;

    [Header("Objects to enable")]
    public GameObject[] objectsToEnable;

    [Header("Objects to disable")]
    public GameObject[] objectsToDisable;

    public void OnButtonClick()
    {
        // Check if all 3 target objects are destroyed
        if (object1 == null && object2 == null && object3 == null)
        {
            Debug.Log("All 3 target objects destroyed! Applying enable/disable lists.");

            // Enable all objects in the enable list
            foreach (GameObject obj in objectsToEnable)
            {
                if (obj != null)
                    obj.SetActive(true);
            }

            // Disable all objects in the disable list
            foreach (GameObject obj in objectsToDisable)
            {
                if (obj != null)
                    obj.SetActive(false);
            }
        }
        else
        {
            Debug.Log("Not all objects are destroyed yet.");
        }
    }
}
