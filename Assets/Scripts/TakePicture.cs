using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class TakePicture : MonoBehaviour
{
    [SerializeField] RawImage display;
    WebCamTexture cam;
    
    void Start()
    {
        cam = new ();
        display.texture = cam;
        cam.Play();
    }

    public void TakePhoto()
    {
        Texture2D photo = new Texture2D(cam.width, cam.height);
        photo.SetPixels(cam.GetPixels());
        photo.Apply();
        File.WriteAllBytes(Application.dataPath + "/photo.png", photo.EncodeToPNG());
    }
}
