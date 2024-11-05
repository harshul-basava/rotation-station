using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class comparingRotations : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject holder;
    GameObject display;
    public GameObject h;
    public GameObject d;
    public bool win;
    public bool w;
    int x;
    int y;
    int z;
    Vector3 rot;
    public int score;
    bool game;
    void Start()
    {
        win = false;
        w = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        game = GameObject.FindWithTag("timer").GetComponent<countdown>().timesUp;

        if (game)
        {
            if (PlayerPrefs.GetString("HSSS", "N/A") == "N/A")
            {
                PlayerPrefs.SetString("HSSS", score.ToString());
                PlayerPrefs.Save();
            }
            else
            {
                if (int.Parse(PlayerPrefs.GetString("HSSS")) < score)
                {
                    PlayerPrefs.SetString("HSSS", score.ToString());
                    PlayerPrefs.Save();
                }
            }
        }

        if(win)
        {
            win = false;

            while (true)
            {
                x = Random.Range(0, 4);
                y = Random.Range(0, 4);
                z = Random.Range(0, 4);

                if(x != 0 || y !=0 || z != 0)
                {
                    break;
                }
            }

            rot = new Vector3(x * 90f, y * 90f, z * 90f);

            Vector3 r = new Vector3(0, 0, 0);
                
            score = score + 1;

            Instantiate(h, new Vector3(0f, 4.5f, 0f), Quaternion.Euler(r));
            Instantiate(d, new Vector3(0f, 11.5f, 0f), Quaternion.Euler(rot));
        }

        holder = GameObject.FindWithTag("holder");
        display = GameObject.FindWithTag("display");

        float angle = Quaternion.Angle(holder.transform.rotation, display.transform.rotation);

        //Debug.Log(angle);
        
        angle = Mathf.Abs(angle);

        if (angle > 12.0f)
        {
            w = false;
        }

        if(angle <= 12.0f && w == false && !game)
        {
            win = true;
            w = true;
        }
    }
}
