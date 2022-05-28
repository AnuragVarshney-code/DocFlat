using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartUp()
    {
        SceneManager.LoadScene("StartUp");
    }
    public void AboutPage()
    {
        SceneManager.LoadScene("AboutPage");
    }
    public void CameraPage()
    {
        SceneManager.LoadScene("CameraPage");
    }
    public void QrPage()
    {
        SceneManager.LoadScene("CameraPage 1");
    }
}
