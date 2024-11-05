using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class highScoreRR : MonoBehaviour
{
    string hs;
    public TextMeshProUGUI t;

    // Start is called before the first frame update
    void Start()
    {
        hs = PlayerPrefs.GetString("HSRR", "N/A");
        t.text = "Best: " + hs;
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "Best: " + hs;
    }
}
