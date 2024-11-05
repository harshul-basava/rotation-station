using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class titlePos : MonoBehaviour
{
    public TextMeshProUGUI t;
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
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(200, 200, 0);
            t.fontSize = 130;
        }
        else if (cw == 1792 && ch == 828)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(400, 200, 0);
            t.fontSize = 130;
        }
        else
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(583, 244, 0);
            t.fontSize = 180;
        }
    }

    // Update is called once per frame
    void Update()
    {
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        if (cw == 1334 && ch == 750)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(200, 200, 0);
            t.fontSize = 130;
        }
        else if (cw == 1792 && ch == 828)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(400, 200, 0);
            t.fontSize = 130;
        }
        else if (cw == 1920 && ch == 1080)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(450, 200, 0);
            t.fontSize = 180;
        }
        else
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(583, 244, 0);
            t.fontSize = 180;
        }
    }
}
