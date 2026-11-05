using UnityEngine;
using UnityEngine.UI;

public class SimplestWebcamAccess : MonoBehaviour
{
    [SerializeField] RawImage display;
    WebCamTexture cam;

    void Start()
    {
        cam = new();
        display.texture = cam;
        cam.Play();
    }
}
