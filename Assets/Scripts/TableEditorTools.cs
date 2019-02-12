using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableEditorTools : MonoBehaviour {

    
    void Start () {
        GameController.instance.ChangeEditorTool(0);
        GameController.instance.ChangeTableHead(0);
        GameController.instance.ChangeTableLegs(0);
        GameController.instance.ChangeTableMaterial(0);
    }
	
	
}
