using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuttableObjectController : MonoBehaviour {
   
    public bool[] objects;
    public Button btnKnife, btnAxe, btnScissors, btnHammer, btnChainsaw;
    public Sprite defaultKnife, defaultAxe, defaultScissors, defaultHammer, defaultChainsaw;
    public Sprite spriteKnife, spriteAxe, spriteScissors, spriteHammer, spriteChainsaw;
    Image imgKnife, imgAxe, imgScissors, imgHammer, imgChainsaw;

    GameObject objKnife;
    GameObject objAxe;
    GameObject objScissors;
    GameObject objHammer;
    GameObject objChainsaw;


    private void Start()
    {
        imgKnife = btnKnife.GetComponent<Image>();
        imgAxe = btnAxe.GetComponent<Image>();
        imgScissors = btnScissors.GetComponent<Image>();
        imgHammer = btnHammer.GetComponent<Image>();
        imgChainsaw = btnChainsaw.GetComponent<Image>();

        objKnife = GameController.instance.objKnife.gameObject;
        objAxe = GameController.instance.objAxe.gameObject;
        objScissors = GameController.instance.objScissors.gameObject;
        objHammer = GameController.instance.objHammer.gameObject;
        objChainsaw = GameController.instance.objChainsaw.gameObject;

    }

    public void SelectedKnife()
    {
        objects[0] = true;
        objects[1] = false;
        objects[2] = false;
        objects[3] = false;
        objects[4] = false;

        imgKnife.overrideSprite = spriteKnife;
        imgAxe.overrideSprite = defaultAxe;
        imgScissors.overrideSprite = defaultScissors;
        imgHammer.overrideSprite = defaultHammer;
        imgChainsaw.overrideSprite = defaultChainsaw;

        objKnife.gameObject.SetActive(true);
        objAxe.gameObject.SetActive(false);
    //    objScissors.gameObject.SetActive(false);
    //    objHammer.gameObject.SetActive(false);
        objChainsaw.gameObject.SetActive(false);

    }

    public void SelectedAxe()
    {
        objects[1] = true;
        objects[0] = false;
        objects[2] = false;
        objects[3] = false;
        objects[4] = false;
        imgKnife.overrideSprite = defaultKnife;
        imgAxe.overrideSprite = spriteAxe;
        imgScissors.overrideSprite = defaultScissors;
        imgHammer.overrideSprite = defaultHammer;
        imgChainsaw.overrideSprite = defaultChainsaw;

        objKnife.gameObject.SetActive(false);
        objAxe.gameObject.SetActive(true);
        objScissors.gameObject.SetActive(false);
        objHammer.gameObject.SetActive(false);
        objChainsaw.gameObject.SetActive(false);


    }
    public void SelectedScissors()
    {
        objects[2] = true;
        objects[1] = false;
        objects[0] = false;
        objects[3] = false;
        objects[4] = false;
        imgKnife.overrideSprite = defaultKnife;
        imgAxe.overrideSprite = defaultAxe;
        imgScissors.overrideSprite = spriteScissors;
        imgHammer.overrideSprite = defaultHammer;
        imgChainsaw.overrideSprite = defaultChainsaw;

    //    objKnife.gameObject.SetActive(false);
        objAxe.gameObject.SetActive(false);
        objScissors.gameObject.SetActive(true);
    //    objHammer.gameObject.SetActive(false);
        objChainsaw.gameObject.SetActive(false);

    }
    public void SelectedHammer()
    {
        objects[3] = true;
        objects[0] = false;
        objects[1] = false;
        objects[2] = false;
        objects[4] = false;
        imgKnife.overrideSprite = defaultKnife;
        imgAxe.overrideSprite = defaultAxe;
        imgScissors.overrideSprite = defaultScissors;
        imgHammer.overrideSprite = spriteHammer;
        imgChainsaw.overrideSprite = defaultChainsaw;

        objKnife.gameObject.SetActive(false);
        objAxe.gameObject.SetActive(false);
        objScissors.gameObject.SetActive(false);
        objHammer.gameObject.SetActive(true);
        objChainsaw.gameObject.SetActive(false);

    }
    public void SelectedChainsaw()
    {
        objects[4] = true;
        objects[0] = false;
        objects[1] = false;
        objects[2] = false;
        objects[3] = false;
        imgKnife.overrideSprite = defaultKnife;
        imgAxe.overrideSprite = defaultAxe;
        imgScissors.overrideSprite = defaultScissors;
        imgHammer.overrideSprite = defaultHammer;
        imgChainsaw.overrideSprite = spriteChainsaw;

        objKnife.gameObject.SetActive(false);
        objAxe.gameObject.SetActive(false);
        objScissors.gameObject.SetActive(false);
        objHammer.gameObject.SetActive(false);
        objChainsaw.gameObject.SetActive(true);

    }

   
   
}
