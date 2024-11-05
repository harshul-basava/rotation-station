using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gyroScript : MonoBehaviour
{
    Vector3 rot;
    float offset;
    Quaternion angle;
    bool win;
    bool game;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;

        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
           win = GameObject.FindWithTag("compare").GetComponent<compareRot>().win;
        } 
        else if (SceneManager.GetActiveScene().name == "lobbyScreen")
        {
            game = false;
            win = false;
        }
        else
        {
            win = GameObject.FindWithTag("compare").GetComponent<comparingRotations>().win;
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
           win = GameObject.FindWithTag("compare").GetComponent<compareRot>().win;
        } 
        else if (SceneManager.GetActiveScene().name == "lobbyScreen")
        {
            game = false;
            win = false;
        }
        else
        {
            win = GameObject.FindWithTag("compare").GetComponent<comparingRotations>().win;
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }
        
        if (!game)
        {
            transform.rotation = Input.gyro.attitude;
            //Debug.Log(transform.rotation);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(new Vector3(0f, 0f, 0f)), 0.05f);
        }

        if(win && !game)
        {
           Destroy(gameObject);
        }
    }
}
