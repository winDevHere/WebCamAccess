using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AnotherTake : MonoBehaviour
{
    [SerializeField] RawImage surfaceDisplay;
    WebCamTexture webcamTexture;
    
    void Start()
    {
        webcamTexture = new ();
        surfaceDisplay.texture = webcamTexture;
        webcamTexture.Play();
    }

    public void TakePhoto()
    {
        Texture2D photo = new Texture2D(webcamTexture.width, webcamTexture.height);
        photo.SetPixels(webcamTexture.GetPixels());
        photo.Apply();
        File.WriteAllBytes(Application.dataPath + "\\photo.png", photo.EncodeToPNG());
    }
}
