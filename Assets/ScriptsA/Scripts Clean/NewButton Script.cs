using UnityEngine;
using UnityEngine.UI;

public class ChangeRawImageTexture2 : MonoBehaviour
{
    public RawImage rawImage;
    public Texture[] textures;
    public GameObject button;
    public GameObject BuildMode;

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
            // Optional: still show last texture once
            rawImage.texture = textures[textures.Length - 1];

            EndSequence();
            return;
        }

        rawImage.texture = textures[currentIndex];
    }

    private void EndSequence()
    {
        if (button != null)
            Destroy(button);

        if (BuildMode != null)
            BuildMode.SetActive(true);
    }
}