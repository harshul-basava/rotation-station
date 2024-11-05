using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randColor : MonoBehaviour
{
    // Start is called before the first frame update
    float r;
    float g;
    float b;
    void Start()
    {
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);
        
        gameObject.GetComponent<Renderer>().material.color = new Color(r, g, b, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
