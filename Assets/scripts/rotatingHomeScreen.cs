using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingHomeScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
        transform.rotation = Input.gyro.attitude;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Input.gyro.attitude;
    }
}
