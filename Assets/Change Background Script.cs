using UnityEngine;
using UnityEngine.UI;

public class ChangeRawImageTexture : MonoBehaviour
{
    public RawImage rawImage;   // Assign in Inspector
    public Texture newTexture;  // Assign the texture you want



     public void ChangeTexture()
    {
        if (rawImage != null && newTexture != null)
        {
            rawImage.texture = newTexture;
        }
    }
}