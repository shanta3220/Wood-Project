using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// responsible for instatiation objects and to move them together
/// </summary>
public class ObjectInstatiatorController : MonoBehaviour
{
    public bool canCubeSpawn, canCapsuleSpawn,  canCylinderSpawn, canSphereSpawn;
    bool[] canSpawn;
    GameObject obj;
    public GameObject initialObj;

    private void Start()
    {
        canSphereSpawn = true;
        canCapsuleSpawn = true;
        canCylinderSpawn = true;
        canSphereSpawn = true;
        canSpawn = new bool[4];
        for(int i = 0; i < 4; i++)
        {
            canSpawn[i] = true;
        }
       

    }
    public void InstatiateObject(int objNumber)
    {
        if (canSpawn[objNumber])
        {
            obj = Instantiate(ObjectController.instance.obj[objNumber], ObjectController.instance.objectTransform[objNumber].position, Quaternion.identity);
            if (initialObj.transform.position == obj.transform.position)
            {
                Destroy(initialObj);
                initialObj = obj;
            }
            else
            {
                initialObj = obj;
            }
            canSpawn[objNumber] = false;
            obj.transform.parent = ObjectController.instance.parent.transform;
        }
        
    }

    public void CanSpawnObject(int objNumber)
    {
        canSpawn[objNumber] = true;

    }
}
