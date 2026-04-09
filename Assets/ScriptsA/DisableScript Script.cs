using UnityEngine;

public class DisableScriptScript : MonoBehaviour
{
    public MonoBehaviour[] scriptsToDisable;

    public void DisableScripts()
    {
        foreach (MonoBehaviour script in scriptsToDisable)
        {
            if (script != null)
                script.enabled = false;
        }

        Debug.Log("All target scripts disabled");
    }
}