using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class buttonLoad : MonoBehaviour
{
    bool game;
    float n;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
        } 
        else if (SceneManager.GetActiveScene().name == "lobbyScreen")
        {
            game = false;
            gameObject.GetComponent<Image>().color = new Color(1.0f,1.0f,1.0f,1.0f);
        }
        else
        {
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }

        gameObject.GetComponent<Image>().color = new Color(1.0f,1.0f,1.0f,0.0f);
        n = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
        } 
        else if (SceneManager.GetActiveScene().name == "lobbyScreen")
        {
            game = false;
            gameObject.GetComponent<Image>().color = new Color(1.0f,1.0f,1.0f,1.0f);
        }
        else
        {
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }

        if (game)
        {
            if (n < 2.0)
            {
                gameObject.GetComponent<Image>().color = new Color(1.0f,1.0f,1.0f,n/2.0f);
                n = n + Time.deltaTime;
            }
            else
            {
                gameObject.GetComponent<Image>().color = new Color(1.0f,1.0f,1.0f,1.0f);
            }  
        } 
    }
}
