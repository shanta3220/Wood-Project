using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this Script is to enabale and DisableTouch
/// </summary>
public class EnableTouch : MonoBehaviour
{

    public GameObject table;
    UserRotateTouch userRotateTouch;
    void Start()
    {
        table.GetComponent<UserRotateTouch>().enabled = false;
        table.GetComponent<UserRotate>().enabled = false;
    }

    public void AllowedRotate()
    {

        table.GetComponent<UserRotateTouch>().enabled = true;
        table.GetComponent<UserRotate>().enabled = true;
    }

    public void NotAllowedRotate()
    {
        table.GetComponent<UserRotateTouch>().enabled = false;
        table.GetComponent<UserRotate>().enabled = false;
    }
}
