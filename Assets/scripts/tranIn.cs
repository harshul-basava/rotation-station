using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tranIn : MonoBehaviour
{
    float dimer;
    // Start is called before the first frame update
    void Start()
    {
        dimer = 0.0f;
        gameObject.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (dimer < 0.25f)
        {
            gameObject.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 1 - (dimer*4f));
            dimer = dimer + Time.deltaTime;
        }
        else
        {
            gameObject.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
            Destroy(gameObject);
        }
    }
}
