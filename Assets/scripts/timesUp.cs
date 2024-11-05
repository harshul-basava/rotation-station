using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class timesUp : MonoBehaviour
{
    GameObject canvas;
    float cw;
    float ch;
    bool game;
    public TextMeshProUGUI t;
    float n;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindWithTag("canvas");
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;   

        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
        } 
        else
        {
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
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
           t.text = "All Done!";
        } 
        else
        {
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }

        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height; 

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

        if((cw == 1334 && ch == 750) || (cw == 1792 && ch == 828))
        {
            t.fontSize = 250;
        }
        else
        {
            t.fontSize = 350;
        }
    }
}
