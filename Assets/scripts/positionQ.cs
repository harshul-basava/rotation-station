using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionQ : MonoBehaviour
{
    GameObject canvas;
    float cw;
    float ch;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindWithTag("canvas");
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        if (cw == 1334 && ch == 750)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(50 - (cw/2), (ch/2) - 50);
        }
        else
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(60 - (cw/2), (ch/2) - 100);
        }
    }

    // Update is called once per frame
    void Update()
    {
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        if (cw == 1334 && ch == 750)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(50 - (cw/2), (ch/2) - 50);
        }
        else
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(60 - (cw/2), (ch/2) - 100);
        }
        
    }
}
