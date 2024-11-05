using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class gosLoad : MonoBehaviour
{
    bool game;
    public Image img;
    float n;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
        } 
        else
        {
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }

        img.GetComponent<Image>().color = new Color32(41,41,41,0);
        n = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "scoreBased")
        {
           game = GameObject.FindWithTag("compare").GetComponent<compareRot>().won;
        } 
        else
        {
            game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;
        }
        
        if (game)
        {
            if (n < 0.823f)
            {
                img.GetComponent<Image>().color = new Color(0.161f,0.161f,0.161f,n);
                n = n + Time.deltaTime;
            }
            else
            {
                img.GetComponent<Image>().color = new Color(0.161f,0.161f,0.161f,0.823f);
            }  
        } 
    }
}
