using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class toExist : MonoBehaviour
{
    int exist;
    // Start is called before the first frame update
    void Start()
    {
        // randomly decide if any given tile exists or deletes itself before the round starts
        
        exist = Random.Range(0, 2);
        if (exist == 1) {
            Destroy(gameObject);
        }
    }
}
