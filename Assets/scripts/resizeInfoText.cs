using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class resizeInfoText : MonoBehaviour
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

        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(cw - 200, ch - 20);
    }

    // Update is called once per frame
    void Update()
    {
        cw = canvas.GetComponent<RectTransform>().rect.width;
        ch = canvas.GetComponent<RectTransform>().rect.height;
    
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(cw - 200, ch - 20);
    }
}
