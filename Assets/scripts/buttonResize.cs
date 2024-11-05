using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonResize : MonoBehaviour
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
            gameObject.GetComponent<RectTransform>().localScale = new Vector2(0.72f, 0.72f);
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(125, -320, 0);
        }
        else if (cw == 1792 && ch == 828)
        {
            gameObject.GetComponent<RectTransform>().localScale = new Vector2(0.72f, 0.72f);
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(125, -320, 0);
        }
        else
        {
            gameObject.GetComponent<RectTransform>().localScale = new Vector2(1f, 1f);
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -431, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        if (cw == 1334 && ch == 750)
        {
            gameObject.GetComponent<RectTransform>().localScale = new Vector2(0.72f, 0.72f);
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(125, -320, 0);
        }
        else if (cw == 1792 && ch == 828)
        {
            gameObject.GetComponent<RectTransform>().localScale = new Vector2(0.72f, 0.72f);
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(125, -320, 0);
        }
        else
        {
            gameObject.GetComponent<RectTransform>().localScale = new Vector2(1f, 1f);
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -431, 0);
        }
    }
}
