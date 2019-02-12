using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// singleton, is a collection of different types of objects like cube, cilinder
/// </summary>
public class ObjectController : MonoBehaviour {
    public GameObject[] obj;
    public GameObject parent;
    public Transform[] objectTransform;
    public static ObjectController instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

}
