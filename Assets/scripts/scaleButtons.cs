using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleButtons : MonoBehaviour
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

        if (cw == 1334 && ch == 750)
        {
           r.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
        }
        else if (cw == 1792 && ch == 828)
        {
            r.localScale = new Vector3 (1.1f, 1.1f, 1.1f);
        }
        else
        {
            r.localScale = new Vector3 (1.4f, 1.4f, 1.4f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;

        if (cw == 1334 && ch == 750)
        {
           r.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
        }
        else if (cw == 1792 && ch == 828)
        {
            r.localScale = new Vector3 (1.1f, 1.1f, 1.1f);
        }
        else
        {
            r.localScale = new Vector3 (1.4f, 1.4f, 1.4f);
        }
    }
}
