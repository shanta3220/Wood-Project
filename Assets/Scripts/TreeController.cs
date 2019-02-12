using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeController : MonoBehaviour {


    public Button btnOak, btnAlder, btnMaple, btnPine, btnWesternRedCedar, btnMahogany;
    public Sprite defaultOak, defaultAlder, defaultMaple, defaultPine, defaultWesternRedCedar, defaultMahogany;
    public Sprite spriteOak, spriteAlder, spriteMaple, spritePine, spriteWesternRedCedar, spriteMahogany;
    public Image imgOak, imgAlder, imgMaple, imgPine, imgWesternRedCedar, imgMahogany;
   

    public bool[] trees;

    
    public void SelectedOak()
    {
        trees[0] = true;
        trees[1] = false;
        trees[2] = false;
        trees[3] = false;
        trees[4] = false;
        trees[5] = false;
        imgOak.overrideSprite = spriteOak;
        imgAlder.overrideSprite = defaultAlder;
        imgMaple.overrideSprite = defaultMaple;
        imgPine.overrideSprite = defaultPine;
        imgWesternRedCedar.overrideSprite = defaultWesternRedCedar;
        imgMahogany.overrideSprite = defaultMahogany;
    }

    public void SelectedAlder()
    {
        trees[1] = true;
        trees[0] = false;
        trees[2] = false;
        trees[3] = false;
        trees[4] = false;
        trees[5] = false;
        imgOak.overrideSprite = defaultOak;
        imgAlder.overrideSprite = spriteAlder;
        imgMaple.overrideSprite = defaultMaple;
        imgPine.overrideSprite = defaultPine;
        imgWesternRedCedar.overrideSprite = defaultWesternRedCedar;
        imgMahogany.overrideSprite = defaultMahogany;
    }
    public void SelectedMaple()
    {
        trees[2] = true;
        trees[1] = false;
        trees[0] = false;
        trees[3] = false;
        trees[4] = false;
        trees[5] = false;
        imgOak.overrideSprite = defaultOak;
        imgAlder.overrideSprite = defaultAlder;
        imgMaple.overrideSprite = spriteMaple;
        imgPine.overrideSprite = defaultPine;
        imgWesternRedCedar.overrideSprite = defaultWesternRedCedar;
        imgMahogany.overrideSprite = defaultMahogany;
    }
    public void SelectedPine()
    {
        trees[3] = true;
        trees[0] = false;
        trees[1] = false;
        trees[2] = false;
        trees[4] = false;
        trees[5] = false;
        imgOak.overrideSprite = defaultOak;
        imgAlder.overrideSprite = defaultAlder;
        imgMaple.overrideSprite = defaultMaple;
        imgPine.overrideSprite = spritePine;
        imgWesternRedCedar.overrideSprite = defaultWesternRedCedar;
        imgMahogany.overrideSprite = defaultMahogany;
    }
    public void SelectedWesternRedCedar()
    {
        trees[4] = true;
        trees[0] = false;
        trees[1] = false;
        trees[2] = false;
        trees[3] = false;
        trees[5] = false;
        imgOak.overrideSprite = defaultOak;
        imgAlder.overrideSprite = defaultAlder;
        imgMaple.overrideSprite = defaultMaple;
        imgPine.overrideSprite = defaultPine;
        imgWesternRedCedar.overrideSprite = spriteWesternRedCedar;
        imgMahogany.overrideSprite = defaultMahogany;
    }

    public void SelectedMahoGany()
    {
        trees[5] = true;
        trees[0] = false;
        trees[1] = false;
        trees[2] = false;
        trees[3] = false;
        trees[4] = false;
        
        imgOak.overrideSprite = defaultOak;
        imgAlder.overrideSprite = defaultAlder;
        imgMaple.overrideSprite = defaultMaple;
        imgPine.overrideSprite = defaultPine;
        imgWesternRedCedar.overrideSprite = defaultWesternRedCedar;
        imgMahogany.overrideSprite = spriteMahogany;
    }
    

    
}
