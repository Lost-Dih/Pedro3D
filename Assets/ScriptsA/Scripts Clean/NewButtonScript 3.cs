using UnityEngine;
using UnityEngine.UI;

public class ChangeRawImageTexture3 : MonoBehaviour
{
    public RawImage rawImage;
    public Texture[] textures;

    public GameObject[] objectsToDisable;
    public GameObject[] objectsToEnable;

    private int currentIndex = -1;

    public void ChangeTexture()
    {
        if (textures == null || textures.Length == 0)
        {
            EndSequence();
            return;
        }

        if (rawImage == null)
            return;

        currentIndex++;

        if (currentIndex >= textures.Length - 1)
        {
            rawImage.texture = textures[textures.Length - 1];
            EndSequence();
            return;
        }

        rawImage.texture = textures[currentIndex];
    }

    private void EndSequence()
    {
        // Disable objects
        foreach (GameObject obj in objectsToDisable)
        {
            if (obj != null)
                obj.SetActive(false);
        }

        // Enable objects
        foreach (GameObject obj in objectsToEnable)
        {
            if (obj != null)
                obj.SetActive(true);
        }
    }
}