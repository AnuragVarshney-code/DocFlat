using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleTimer : MonoBehaviour
{
    public Toggle timeValue1, timeValue2, timeValue3;
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toggleTime()
    {
        if (timeValue1.isOn)
        {
            value = 3;
            timeValue2.isOn = false;
            timeValue3.isOn = false;
        }
        if (timeValue2.isOn)
        {
            value = 5;
            timeValue1.isOn = false;
            timeValue3.isOn = false;
        }
        if (timeValue3.isOn)
        {
            value = 10;
            timeValue1.isOn = false;
            timeValue2.isOn = false;
        }
        if(timeValue1.isOn|| timeValue2.isOn|| timeValue3.isOn)
        {

        }
        else
        {
            value = 0;
        }
        Debug.Log(value);
    }
}
