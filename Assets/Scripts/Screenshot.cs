using System.Collections;
using System.IO;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    public GameObject UI;
    //private int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator ScreenShot()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(Screen.width,Screen.height,TextureFormat.RGB24,false);

        texture.ReadPixels(new Rect(0, 0, Screen
            .width, Screen.height), 0, 0);
        texture.Apply();

        string name = "ScreenShot " + System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png";
        //i++;

        //PC
        //byte[] bytes = texture.EncodeToPNG();
        //File.WriteAllBytes(Application.dataPath + "/../"+name,bytes);

        //MOBILE
        NativeGallery.SaveImageToGallery(texture,"DocFlat", name);
        Destroy(texture);
        UI.SetActive(true);
    }

    public void takeScreenShot()
    {
        UI.SetActive(false);
        StartCoroutine("ScreenShot");
    }
}
