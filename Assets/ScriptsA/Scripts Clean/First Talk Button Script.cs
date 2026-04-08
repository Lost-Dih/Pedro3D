using UnityEngine;
using UnityEngine.UI;


public class FirstTalkButtonScript : MonoBehaviour
{
    public RawImage rawImage;      // Assign in Inspector
    public GameObject button;
    public Texture textures;
    public GameObject ArrowButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeTexture()
    {

        if (rawImage != null && textures != null)
        {
            rawImage.texture = textures;
        }

        if (button != null)
                Destroy(button);
            ArrowButton.SetActive(true);
            return;
        }
    }

