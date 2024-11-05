using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class scorePos : MonoBehaviour
{
    bool game;
    public TextMeshProUGUI t;
    float n;
    GameObject canvas;
    float cw;
    float ch;
    string score;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindWithTag("canvas");
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;
        t.text = "Score: 0";

        if(cw == 1334 && ch == 750)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
        }
        else
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -250, 0);
        }

        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
           score = GameObject.FindWithTag("timer").GetComponent<countup>().displayTime;
        } 
        else
        {
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
            score = GameObject.FindWithTag("compare").GetComponent<comparingRotations>().score.ToString();
        }

        t.color = new Color(1.0f,1.0f,1.0f,0.0f);
        n = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
           score = GameObject.FindWithTag("timer").GetComponent<countup>().displayTime;
        } 
        else
        {
            score = GameObject.FindWithTag("compare").GetComponent<comparingRotations>().score.ToString();
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }
        
        t.text = "Score: " + score;

        if (game)
        {
            if (n < 2.0)
            {
                t.color = new Color(1.0f,1.0f,1.0f,n/2.0f);
                n = n + Time.deltaTime;
            }
            else
            {
                t.color = new Color(1.0f,1.0f,1.0f,1.0f);
            }  
        } 

        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        if ((cw == 1334 && ch == 750) || (cw == 1792 && ch == 828))
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -200, 0);
        }
        else
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -250, 0);
        }
    }
}
