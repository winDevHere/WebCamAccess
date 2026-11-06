using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AnotherTake2 : MonoBehaviour
{
    [SerializeField] RawImage rawImage;
    WebCamTexture webCamTexture;
    
    void Start()
    {
        webCamTexture = new ();
        rawImage.texture = webCamTexture;
    }

    public void TakePhoto()
    {
        Texture2D photo = new Texture2D(webCamTexture.width, webCamTexture.height); // Prep and init container for picture to take
        Color[] colors = new Color[256 * 256];
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] = Color.red;
        }
        photo.SetPixels(colors);
        photo.Apply();
        File.WriteAllBytes(Application.dataPath + "\\photo.png", photo.EncodeToPNG());
        
    }
}
