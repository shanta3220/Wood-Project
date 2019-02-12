using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableCustomizationController : MonoBehaviour {
    public Slider tableHead;
    public Slider tableLegs;

    void Start()
    {
        GameController.instance.ChangeTableHead((int)tableHead.value);
        GameController.instance.ChangeTableLegs((int)tableLegs.value);

        tableHead.onValueChanged.AddListener((delegate { GameController.instance.ChangeTableHead((int)tableHead.value); }));
        tableLegs.onValueChanged.AddListener((delegate { GameController.instance.ChangeTableLegs((int)tableLegs.value); }));
    }
    

}
