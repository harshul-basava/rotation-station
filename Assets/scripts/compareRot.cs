using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class compareRot : MonoBehaviour
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
    public bool won;
    void Start()
    {
        win = false;
        w = false;
        score = 10;
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (score <= 0)
        {
            score = 0;
            won = true;
        }

        if (!won)
        {   
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
                    
                score = score - 1;

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

            if(angle <= 12.0f && w == false)
            {
                win = true;
                w = true;
            }
        }
    }
}

