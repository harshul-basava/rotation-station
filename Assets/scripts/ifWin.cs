using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ifWin : MonoBehaviour
{
    bool win;
    bool game;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
           win = GameObject.FindWithTag("compare").GetComponent<compareRot>().win;
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
        else
        {
            win = GameObject.FindWithTag("compare").GetComponent<comparingRotations>().win;
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }

        if (win && !game)
        {
            Destroy(gameObject);
        }
    }
}
