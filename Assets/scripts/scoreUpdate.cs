using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class scoreUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    int score;
    public TextMeshProUGUI t;
    GameObject canvas;
    float cw;
    float ch;
    bool game;
    float n;
    void Start()
    {
        score = 0;
        canvas = GameObject.FindWithTag("canvas");
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        t.color = new Color(1.0f,1.0f,1.0f,1.0f);
        n = 1.0f;

        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
           score = GameObject.FindWithTag("compare").GetComponent<compareRot>().score;
        } 
        else
        {
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
           score = GameObject.FindWithTag("compare").GetComponent<compareRot>().score;
        } 
        else
        {
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
            score = GameObject.FindWithTag("compare").GetComponent<comparingRotations>().score;
        }
        
        if (!game)
        {
            t.text = "" + score;
        }
        else
        {
            if (n > 0f)
            {
                t.color = new Color(1.0f,1.0f,1.0f,1.0f - (0.5f * n));
                n = n + Time.deltaTime;
            }
            else
            {
                t.color = new Color(1.0f,1.0f,1.0f, 0.0f);
            }
        }

        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        if((cw == 1334 && ch == 750)|| (cw == 1792 && ch == 828))
        {
            t.fontSize = 180;
        }
        else
        {
            t.fontSize = 300;
        }
    }
}
