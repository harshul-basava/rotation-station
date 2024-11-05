using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;


public class countup : MonoBehaviour
{
    float time;
    int seconds;
    int minutes;
    public TextMeshProUGUI t;
    GameObject canvas;
    float cw;
    float ch;
    bool won;
    public string displayTime;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        canvas = GameObject.FindWithTag("canvas");
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;
        t.text = "0:00";

        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, (ch/2) - 95, 0);
        won = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
    }

    // Update is called once per frame
    void Update()
    {
        won = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;

        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, (ch/2) - 125, 0);

        if(!won)
        {
            time = Time.timeSinceLevelLoad;

            minutes = Mathf.FloorToInt(time/60);
            seconds = Mathf.FloorToInt(time%60);

            displayTime = minutes + ":" + seconds;
            t.text = displayTime;

            if (seconds < 10 & time >= 0)
            {
                displayTime = minutes + ":0" + seconds;
                t.text = displayTime;
            }
        }
        else
        {
            if (PlayerPrefs.GetString("HSRR", "N/A") == "N/A")
            {
                PlayerPrefs.SetInt("minutes", minutes);
                PlayerPrefs.SetInt("seconds", seconds);
                PlayerPrefs.SetString("HSRR", displayTime);

                PlayerPrefs.Save();
            }
            else
            {
                if (PlayerPrefs.GetInt("minutes") > minutes)
                {
                    PlayerPrefs.SetInt("minutes", minutes);
                    PlayerPrefs.SetInt("seconds", seconds);
                    PlayerPrefs.SetString("HSRR", displayTime);

                    PlayerPrefs.Save();
                }
                else if ((PlayerPrefs.GetInt("minutes") == minutes) && (PlayerPrefs.GetInt("seconds") > seconds))
                {
                    PlayerPrefs.SetInt("minutes", minutes);
                    PlayerPrefs.SetInt("seconds", seconds);
                    PlayerPrefs.SetString("HSRR", displayTime);

                    PlayerPrefs.Save();
                }
            }
        }
    }
}
