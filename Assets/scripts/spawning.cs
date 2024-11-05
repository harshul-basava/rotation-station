using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject p;
    public Transform t;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(p, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 10 == 0)
        {
            Instantiate(p, transform.position, transform.rotation, t);
        }
    }
}
