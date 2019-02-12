using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserRotate : MonoBehaviour
{

    private float rotationRate = 3.0f;
    private float h;
    private float v;

    void Update()
    {
        // get the user input
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (h != 0 || v != 0)
        {
            transform.Rotate(v * rotationRate, -h * rotationRate, 0, Space.World);
        }
    }
}