using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO; //for working with files.
using System.Runtime.Serialization.Formatters.Binary; //RSFB helps Serialization
using DG.Tweening;

/// <summary>
/// manages the important features like keeping the score, restarting levels
/// saving/loading data, updating HUD etc
/// </summary>

public class Game : MonoBehaviour
{

    public static Game instance;
    public float restartDelay;
    public Vector3 playerInitialPos;
   

    void Awake()
    {
        if (instance == null)
            instance = this;
        //dataFilePath = Application.persistentDataPath + "/game.dat";

        //Debug.Log(dataFilePath);
        
    }

    void Start()
    {
    }
    /// <summary>
    /// Get the score for level complete menu
    /// </summary>
    /// <returns>the score.</returns>
   


    void GameOver()
    {
        //ui.panelGameOver.SetActive(true);
       // ui.panelGameOver.gameObject.GetComponent<RectTransform>().DOAnchorPosY(0f, 0.7f, false);
       // if (ui.panelMobileUI.activeInHierarchy)
           // ui.panelMobileUI.SetActive(false);
       // data.firstBoot = true;
        //Invoke("ResetLevelData", restartDelay);
    }

    /// <summary>
    /// shows pause panel
    /// </summary>
    public void ShowPausePanel()
    {
        //if (ui.panelMobileUI.activeInHierarchy)
         //   ui.panelMobileUI.SetActive(false);
       // ui.panelPause.SetActive(true);
       // ui.panelPause.gameObject.GetComponent<RectTransform>().DOAnchorPosY(0, 0.7f, false);
       // ui.btnPause.interactable = false;
        Invoke("SetPause", 1.1f);
    }

    
    
}
