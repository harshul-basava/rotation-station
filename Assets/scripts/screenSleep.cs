using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class screenSleep : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased" || SceneManager.GetActiveScene().name == "timeBased")
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }
        else
        {
            Screen.sleepTimeout = SleepTimeout.SystemSetting;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased" || SceneManager.GetActiveScene().name == "timeBased")
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }
        else
        {
            Screen.sleepTimeout = SleepTimeout.SystemSetting;
        }
    }
}
