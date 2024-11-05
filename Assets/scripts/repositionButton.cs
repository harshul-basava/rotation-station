using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class repositionButton : MonoBehaviour
{
    RectTransform r;
    GameObject canvas;
    float cw;
    float ch;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindWithTag("canvas");

        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        r = gameObject.GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        if ((cw == 1334 && ch == 750) || (cw == 1792 && ch == 828))
        {
           gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(gameObject.GetComponent<RectTransform>().anchoredPosition.x, 100 - (ch/2), 0);
           r.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
        }
        else
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(gameObject.GetComponent<RectTransform>().anchoredPosition.x, 150 - (ch/2), 0);
            r.localScale = new Vector3 (1.25f, 1.25f, 1.25f);
        }
    }
}
