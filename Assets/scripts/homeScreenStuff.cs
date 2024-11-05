using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeScreenStuff : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject p;
    void Start()
    {
        transform.localRotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.identity;
        //Instantiate(p, transform.position, transform.rotation);
        if (Time.frameCount % 10 == 0)
        {
            Destroy(gameObject);
        }
    }
}
