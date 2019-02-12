using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableModelController : MonoBehaviour {
    
    public int modelNumber;
    public Image imgSelected;
    public GameObject[] furnishingTools;

	
    public void ChangeTableHead()
    {
        imgSelected.transform.SetParent(gameObject.transform);
        imgSelected.transform.position = transform.position;
        GameController.instance.ChangeTableHead(modelNumber);
    }

    public void ChangeTableLegs()
    {
        imgSelected.transform.SetParent(gameObject.transform);
        imgSelected.transform.position = transform.position;
        GameController.instance.ChangeTableLegs(modelNumber);
    }

    public void ChangeMaterial()
    {
        imgSelected.transform.SetParent(gameObject.transform);
        imgSelected.transform.position = transform.position;
        GameController.instance.ChangeTableMaterial(modelNumber);
    }

    public void ChangeFurnishingTools()
    {
        imgSelected.transform.SetParent(gameObject.transform);
        imgSelected.transform.position = transform.position;
        for (int i = 0; i < furnishingTools.Length; i++)
        {
            furnishingTools[i].SetActive(false);
        }
        furnishingTools[modelNumber].SetActive(true);
    }
}
