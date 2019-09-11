using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static float time;
    public Text timerText;
    
    // Start is called before the first frame update
    void Start()
    {
        time = 60.0f;
        SetTimerText();
    }

    // Update is called once per frame
    void Update()
    {
        SetTimerText();
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        Debug.Log(time);
        
    }

    void SetTimerText()
    {
        timerText.text = "" + (int)time;
    }
}
