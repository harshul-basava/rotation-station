using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject teehee;
    void Start()
    {
        if(!PlayerPrefs.HasKey("scoreFirstTime") || PlayerPrefs.GetInt("scoreFirstTime") != 1)
        {
            //do nothing
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    public void information()
    {
        teehee.SetActive(true);
        Destroy(gameObject);
    }
}
