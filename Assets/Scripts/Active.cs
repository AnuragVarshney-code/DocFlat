#if !(PLATFORM_LUMIN && !UNITY_EDITOR)

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UnityUtils.Helper;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class Active : MonoBehaviour
{
    public Toggle cameraSwitchButton, flashButton;
    public Toggle rotate90deg,timerOption,captureBtn,t3,t5,t10;
    public GameObject toggleOptions,timerCapture;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void flashButtonPressed()
    {
        if (flashButton.isOn)
        {
            
            flashButton.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            flashButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void captureBtnPressed()
    {
        if (captureBtn.isOn)
        {

            captureBtn.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            captureBtn.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void cameraSwitchButtonPressed()
    {
        if (cameraSwitchButton.isOn)
        {
            cameraSwitchButton.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            cameraSwitchButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void rotate90deg_Pressed()
    {
        if (rotate90deg.isOn)
        {
            rotate90deg.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            rotate90deg.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void timerOptionPressed()
    {
        if (timerOption.isOn)
        {
            toggleOptions.SetActive(true);
            timerOption.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            toggleOptions.SetActive(false);
            timerOption.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void t3pressed()
    {
        if (t3.isOn)
        {
            t3.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            t3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void t5pressed()
    {
        if (t5.isOn)
        {
            t5.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            t5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    public void t10pressed()
    {
        if (t10.isOn)
        {
            t10.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            t10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
}
    
#endif