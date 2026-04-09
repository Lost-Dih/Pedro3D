using UnityEngine;

public class SimpleClickDelete : MonoBehaviour
{
    public GameObject targetObject; // object to destroy

    public void DestroyTarget()
    {
        if (targetObject != null)
        {
            Destroy(targetObject);
            Debug.Log(targetObject.name + " destroyed");
        }
    }
}