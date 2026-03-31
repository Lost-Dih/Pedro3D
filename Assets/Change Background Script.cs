using UnityEngine;
using UnityEngine.UI;

public class ChangeRawImageTexture : MonoBehaviour
{
    public RawImage rawImage;      // Assign in Inspector
    public Texture[] textures;     // Add multiple textures in Inspector
    public GameObject button;      // Assign your button here
    

    private int currentIndex = -1;

    public void ChangeTexture()
    {
        if (rawImage == null || textures.Length == 0)
            return;

        currentIndex++;

        // If we've reached the end
        if (currentIndex >= textures.Length)
        {
            // Destroy the button
            if (button != null)
                Destroy(button);
    
            return;
        }

        // Apply texture
        rawImage.texture = textures[currentIndex];
    }
}