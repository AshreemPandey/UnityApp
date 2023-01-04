using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class saver : MonoBehaviour
{
    public GameObject icon1;
    public GameObject icon2;
    public GameObject icon3;   

    private IEnumerator Image()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture=new Texture2D(Screen.width, Screen.height,TextureFormat.RGB24,false);
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height),0,0);
        texture.Apply();

        string name = "Paint_image" + System.DateTime.Now.ToString("yy-MM-dd-HH-mm-ss")+" .png";

        NativeGallery.SaveImageToGallery(texture, "Unity_Pictures", name);

        Destroy(texture);
        icon1.SetActive(true);
        icon2.SetActive(true);
        icon3.SetActive(true);
    }    
    
    public void generateImage()
    {
        icon1.SetActive(false);
        icon2.SetActive(false);
        icon3.SetActive(false);
        StartCoroutine(Image());
    }
}
