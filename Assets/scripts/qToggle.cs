using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qToggle : MonoBehaviour
{
    public GameObject teehee;

    public void qButton()
    {
        if (teehee.activeInHierarchy)
        {
            teehee.SetActive(false);
        }
        else
        {
            teehee.SetActive(true);
        }
    }
}
