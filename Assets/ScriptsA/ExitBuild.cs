using UnityEngine;
using UnityEngine.UI;

public class ExitBuild : MonoBehaviour
{
public GameObject BuildMode;
public GameObject DecorationMode;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeMode()
    {
          BuildMode.SetActive(true);
          DecorationMode.SetActive(false);
    
    }




}