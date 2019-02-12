using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWeapon : MonoBehaviour {

    public CuttableObjectController cuttableObjectController;
    public int weaponNumber;
    public void SelectedWeapon()
    {
        if (weaponNumber == 1)
        {
            cuttableObjectController.SelectedKnife();
            GameController.instance.weaponValue = 1;
        }

        if (weaponNumber == 2)
        {
            cuttableObjectController.SelectedAxe();
            GameController.instance.weaponValue = 2;
        }

        if (weaponNumber == 3)
        {
            cuttableObjectController.SelectedScissors();
            GameController.instance.weaponValue = 3;
        }

        if (weaponNumber == 4)
        {
            cuttableObjectController.SelectedHammer();
            GameController.instance.weaponValue = 4;
        }
        if (weaponNumber == 5)
        {
            cuttableObjectController.SelectedChainsaw();
            GameController.instance.weaponValue = 5;
        }
       
    }

}
