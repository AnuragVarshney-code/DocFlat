using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class More_n_Less : MonoBehaviour
{
    public GameObject menu1Active, menu1orig, buttonLessnMore, buttonUPnDOWN;
    public bool MoveMenuPanelup, MoveMenuPaneldown;
    //private bool lessnmore = false;
    public float moveSpeed,tempMenuPos;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        buttonLessnMore.transform.position = menu1orig.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveMenuPanelup)
        {
            buttonLessnMore.transform.position = Vector3.Lerp(buttonLessnMore.transform.position, menu1Active.transform.position, moveSpeed * Time.deltaTime);
            if(buttonLessnMore.transform.localPosition.y == tempMenuPos)
            {
                MoveMenuPanelup = false;
                buttonLessnMore.transform.position = menu1Active.transform.position;
                tempMenuPos = -999999999999.99f;
            }
            if (MoveMenuPanelup)
            {
                tempMenuPos = buttonLessnMore.transform.position.y;
            }
            //Debug.Log("up = 1 and down = 0");
        }
        if (MoveMenuPaneldown)
        {
            buttonLessnMore.transform.position = Vector3.Lerp(buttonLessnMore.transform.position, menu1orig.transform.position, moveSpeed * Time.deltaTime);
            if (buttonLessnMore.transform.localPosition.y == tempMenuPos)
            {
                MoveMenuPaneldown = false;
                buttonLessnMore.transform.position = menu1orig.transform.position;
                tempMenuPos = -999999999999.99f;
            }
            if (MoveMenuPaneldown)
            {
                tempMenuPos = buttonLessnMore.transform.position.y;
            }
            //Debug.Log("up = 0 and down = 1");
        }
    }

    public void buttonPressed()
    {
        if (i % 2 == 0)
        {
            buttonUPnDOWN.GetComponent<Image>().color = new Color32(0, 191, 255, 255);
            MoveMenuPaneldown = false;
            MoveMenuPanelup = true;
        }
        else
        {
            buttonUPnDOWN.GetComponent<Image>().color = new Color32(255,255,255,255);
            MoveMenuPanelup = false;
            MoveMenuPaneldown = true;
        }
        i++;
    }
}
