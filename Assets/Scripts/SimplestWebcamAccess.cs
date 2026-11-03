using UnityEngine;
using UnityEngine.UI;

public class SimplestWebcamAccess : MonoBehaviour
{
    [SerializeField] RawImage display;


    void Start()
    {
        WebCamTexture cam = new WebCamTexture();
        display.texture = cam;
    }

    void Update()
    {
        
    }
}
