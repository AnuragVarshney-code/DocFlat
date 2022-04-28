using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Active : MonoBehaviour
{
    private int i = 0,j=0;
    public bool MoveMenuPanelup, MoveMenuPaneldown;
    public GameObject cameraSwitchButton, flashButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cameraSwitchButtonPressed()
    {
        if (i % 2 == 0)
        {
            cameraSwitchButton.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            cameraSwitchButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        i++;
    }

    public void flashButtonPressed()
    {
        if (j % 2 == 0)
        {
            flashButton.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
        }
        else
        {
            flashButton.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        j++;
    }
}
