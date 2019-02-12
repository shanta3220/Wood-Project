using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChanger : MonoBehaviour
{

    public TreeController treeController;
    public int treeNumber;


    public void SelectedTree()
    {
        if(treeNumber == 0)
        {
            treeController.SelectedOak();
        }

        if (treeNumber == 1)
        {
            treeController.SelectedAlder();
        }

        if (treeNumber == 2)
        {
            treeController.SelectedMaple();
        }

        if (treeNumber == 3)
        {
            treeController.SelectedPine();
        }
        if (treeNumber == 4)
        {
            treeController.SelectedWesternRedCedar();
        }
        if (treeNumber == 5)
        {
            treeController.SelectedMahoGany();
        }
    }
}

