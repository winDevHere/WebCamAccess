using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AnotherTake1 : MonoBehaviour
{
    WebCamTexture webCamTexture;
    [SerializeField] RawImage surfaceDisplay;
    Texture2D photo;

    void Start()
    {
        webCamTexture = new ();
        surfaceDisplay.texture = webCamTexture;
        webCamTexture.Play();
    }

    public void TakePhoto()
    {
        photo = new Texture2D(webCamTexture.width, webCamTexture.height);           // initialize the texture2d
        photo.SetPixels(webCamTexture.GetPixels());                                 // Putting something on the container
        photo.Apply();                                                              // Execute
        File.WriteAllBytes(Application.dataPath + "\\photo.jpg", photo.EncodeToJPG());  // Save to Assets folder
    }
}
