using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// the editor tool for the table
/// </summary>
public class TableEditorController : MonoBehaviour {

    public int toolNumber;
    public Image editorSelected;
	
    public void ChangeEditorTool()
    {
        editorSelected.transform.SetParent(gameObject.transform);
        editorSelected.transform.position = transform.position;
        GameController.instance.ChangeEditorTool(toolNumber);
    }
}
