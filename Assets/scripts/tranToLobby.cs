using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tranToLobby : MonoBehaviour
{
    bool ready;
    float dimer;
    // Start is called before the first frame update
    void Start()
    {
        ready = false;
        dimer = 0.0f;
        gameObject.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (dimer < 0.25f)
        {
            gameObject.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, dimer*4f);
            dimer = dimer + Time.deltaTime;
        }
        else
        {
            gameObject.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
            ready = true;
        }

        if(ready)
        {
            if(!PlayerPrefs.HasKey("scoreFirstTime") || PlayerPrefs.GetInt("scoreFirstTime") != 1)
            {
                PlayerPrefs.SetInt("scoreFirstTime", 1);

                //resetting score & coin counts
                PlayerPrefs.SetString("HSSS", "N/A");
                PlayerPrefs.SetString("HSRR", "N/A");

                PlayerPrefs.Save();
            }

            SceneManager.LoadScene("lobbyScreen");
        }
    }
}