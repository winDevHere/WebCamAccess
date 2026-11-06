using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AnotherTake3 : MonoBehaviour
{
    [SerializeField] RawImage display;
    WebCamTexture webCamTexture;

    void Start()
    {
        webCamTexture = new();
        webCamTexture.Play();
        display.texture = webCamTexture;
    }

    public void TakePhoto()
    {
        Texture2D   photo = new Texture2D(webCamTexture.width, webCamTexture.height);
                    photo.SetPixels(webCamTexture.GetPixels());
                    photo.Apply();
        File.WriteAllBytes(Application.dataPath + "\\photo.png", photo.EncodeToPNG());
    }
}
