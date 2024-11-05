using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class displayCreation : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // If the tile with the same name exists on the player cube, delete the tile on this cube to
        // create the inverse version of the cube
        
        if(GameObject.Find(gameObject.name).tag == "play")
        {
            Destroy(gameObject); 
        }
    }
}
