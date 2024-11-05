using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class countdown : MonoBehaviour
{
    float time;
    int seconds;
    int minutes;
    public TextMeshProUGUI t;
    GameObject canvas;
    float cw;
    float ch;
    public bool timesUp;
    // Start is called before the first frame update
    void Start()
    {
        timesUp = false;
        time = 120;
        canvas = GameObject.FindWithTag("canvas");
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;
        t.text = "2:00";

        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, (ch/2) - 95, 0);
    }

    // Update is called once per frame
    void Update()
    {
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, (ch/2) - 125, 0);

        time = 120 - Time.timeSinceLevelLoad;

        minutes = Mathf.FloorToInt(time/60);
        seconds = Mathf.FloorToInt(time%60);


        if (time <= 0)
        {
            time = 0;
            t.text = "0:00";
            timesUp = true;
            
        }
        else
        {
            t.text = minutes + ":" + seconds;
        }

        if (seconds < 10 & time > 0)
        {
            t.text = minutes + ":0" + seconds;
        }
    }
}
