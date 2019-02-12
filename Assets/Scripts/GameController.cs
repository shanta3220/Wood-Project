using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// is reponsible for handling ui elements, editing tables, different types of animation etc
/// </summary>
public class GameController : MonoBehaviour {

    public UIElements ui;
    public SFX sfx;
    public GameObject tree, axe, trunk, stage, chainsaw;
    public int weaponValue;

    public static GameController instance;

    public GameObject objKnife;
    public GameObject objAxe;
    public GameObject objScissors;
    public GameObject objHammer;
    public GameObject objChainsaw;
    public Table table;
    public GameObject WoodAnim;


    public int activeTableHeadNum = 0;
    public int activeTableLegsNum = 0;
    public int activeMatNum = 0;
    float activeSmoothnessVal = 0;
    float activeShininessVal = 0;
    float weaponSelectedNum;
    Transform treeTransform;


    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        treeTransform = tree.transform;
    }

    /// <summary>
    /// responsible to detect if correct object is selected to cut the tree 
    /// </summary>
    public void TreeCuttingAnimation()
    {
        if (weaponValue == 2)
        {
            ui.panelTree.SetActive(false);
            ui.panelWeapons.SetActive(false);
            weaponSelectedNum = 2;
            EnableAnimatedObjects();
            objAxe.gameObject.SetActive(false);
            AudioController.instance.CuttingTreeAudio(0);
            Invoke("DisableAnimatedObjects", 4f);
        }
        if (weaponValue == 5)
        {
            ui.panelTree.SetActive(false);
            ui.panelWeapons.SetActive(false);
            weaponSelectedNum = 5;
            EnableAnimatedObjects();
            AudioController.instance.CuttingTreeAudio(1);
            objChainsaw.gameObject.SetActive(false);
            Invoke("DisableAnimatedObjects", 4f);
        }
        else
        {
            ui.selectCorrectWeapon.SetActive(true);
            Invoke("SelectCorrectWeaponDisable", 2f);
        }


    }

    /// <summary>
    /// activates the weapon panel
    /// </summary>

    public void GoToPanelWeapon()
    {
        ui.panelTree.GetComponent<RectTransform>().DOAnchorPosX(-1048f, 1, false);
        ui.panelWeapons.GetComponent<RectTransform>().DOAnchorPosX(0f, 1, false);
      
        ui.panelWeapons.SetActive(true);

    }

    /// <summary>
    /// goes back to panel tree selection
    /// </summary>
    public void GoBackToPanelTree()
    {
        ui.panelTree.SetActive(true);
        ui.panelTree.GetComponent<RectTransform>().DOAnchorPosX(0f, 1, false);
        if (ui.panelWeapons.activeInHierarchy)
        {
            ui.panelWeapons.GetComponent<RectTransform>().DOAnchorPosX(-1048f, 1, false);
            
        }

        if (objAxe.activeInHierarchy)
            objAxe.SetActive(false);
        else if (objChainsaw.activeInHierarchy)
            objChainsaw.SetActive(false);
        else if (objHammer.activeInHierarchy)
            objChainsaw.SetActive(false);
       
    }
    
    IEnumerator TurnOffPanel(GameObject panel)
    {
        yield return new WaitForSeconds(2);
        panel.SetActive(false);
    }
    


    /// <summary>
    /// goes back to panel correct object selection
    /// </summary>

    public void GoBackToPanelWeapon()
    {
        tree.transform.position = treeTransform.position;
        tree.transform.rotation = treeTransform.rotation;
        ui.panelWeapons.SetActive(true);
        ui.panelWeapons.GetComponent<RectTransform>().DOAnchorPosX(0f, 1, false);
        if (ui.panelEditor.activeInHierarchy)
        {
           
            table.tableHead[activeTableHeadNum].SetActive(false);
            table.tableLegs[activeTableLegsNum].SetActive(false);
            ui.panelEditor.SetActive(false);
           


        }
        if (weaponSelectedNum == 2)
            objAxe.SetActive(true);
        if (weaponSelectedNum == 5)
            objChainsaw.SetActive(true);
    }


    /// <summary>
    /// disables the cutting object
    /// </summary>

    public void SelectCorrectWeaponDisable()
    {
        ui.selectCorrectWeapon.SetActive(false);
    }


    /// <summary>
    /// handles cutting animation of tree with axe
    /// </summary>
    public void EnableAnimatedObjects()
    {
        
        stage.gameObject.SetActive(false);
        tree.gameObject.SetActive(true);
        trunk.gameObject.SetActive(true);
        WeaponCuttingAnimation(true);
        if (weaponSelectedNum == 2)
        {
            axe.GetComponent<CuttingAnimationController>().delay = 1.8f;
            axe.GetComponent<CuttingAnimationController>().CanCut();
            tree.GetComponent<TreeFalls>().delay = 2f;



        }
        if (weaponSelectedNum == 5)
        {
            chainsaw.GetComponent<CuttingAnimationController>().delay = 1.2f;
            chainsaw.GetComponent<CuttingAnimationController>().CanCut();
            tree.GetComponent<TreeFalls>().delay = 1.5f;


        }
        tree.GetComponent<TreeFalls>().ResetTreeAnimation();
        tree.GetComponent<TreeFalls>().SetupTreeAnimation();
       
    }

    public void EnableEditorTool()
    {
        ui.panelEditor.gameObject.SetActive(true);
        AudioController.instance.audioSource.clip = null;

    }

    public void ShowSparkle()
    {
        Instantiate(sfx.sfx_sparkle, sfx.sparkle_transform.position, Quaternion.identity);

    }

    /// <summary>
    /// disables animation of the cutting tree
    /// </summary>
    public void DisableAnimatedObjects()
    {
        tree.gameObject.SetActive(false);
        trunk.gameObject.SetActive(false);
        WeaponCuttingAnimation(false);
        WoodAnim.SetActive(true);
        WoodAnim.GetComponent<GettingWoodController>().SetupAnimation();
        ui.panelWeapons.GetComponent<RectTransform>().DOAnchorPosX(-1048f, 1, false);
        
    }

    public void WeaponCuttingAnimation(bool toggle)
    {
        if (weaponSelectedNum == 2)
        {
            axe.gameObject.SetActive(toggle);
        }
        if (weaponSelectedNum == 5)
        {
            chainsaw.gameObject.SetActive(toggle);
        }
    }

    /// <summary>
    /// handles which editor to be activated
    /// </summary>

    public void ChangeEditorTool(int toolNumber)
    {
        for (int i = 0; i < table.editorTool.Length; i++)
        {
            table.editorTool[i].SetActive(false);
        }
        table.editorTool[toolNumber].SetActive(true);
    }

    /// <summary>
    /// changes table head model
    /// </summary>

    public void ChangeTableHead(int tableHeadNumber)
    {
        for(int i = 0; i< table.tableLegs.Length; i++)
        {
            table.tableHead[i].gameObject.SetActive(false);
            
        }
       
        table.tableHead[tableHeadNumber].gameObject.SetActive(true);
        activeTableHeadNum = tableHeadNumber;

        table.tableHead[tableHeadNumber].transform.GetComponent<MeshRenderer>().material = table.tableMat[activeMatNum];
    }

    /// <summary>
    /// changes table legs model
    /// </summary>
    public void ChangeTableLegs(int tableLegsNumber)
    {
        for (int i = 0; i < table.tableLegs.Length; i++)
        {
            table.tableLegs[i].SetActive(false);
        }
        table.tableLegs[tableLegsNumber].SetActive(true);
        activeTableLegsNum = tableLegsNumber;
        ChangeLegsMaterial();
        
    }

    /// <summary>
    /// this function changes table material and handles smoothness+shineness when material is changed
    /// </summary>
    public void ChangeTableMaterial(int matNumber)
    {
        table.tableHead[activeTableHeadNum].transform.GetComponent<MeshRenderer>().material = table.tableMat[matNumber];
        table.tableHead[activeTableHeadNum].transform.GetComponent<MeshRenderer>().material.SetFloat("_Metallic", activeSmoothnessVal);
        table.tableHead[activeTableHeadNum].transform.GetComponent<MeshRenderer>().material.SetFloat("_Glossiness", activeShininessVal);
        activeMatNum = matNumber;
        ChangeLegsMaterial();
    }


    /// <summary>
    /// this function changes table legs material, smoothness, shineness one by one
    /// </summary>
    public void ChangeLegsMaterial()
    {
       
        int numOfLegs = table.tableLegs[activeTableLegsNum].transform.childCount;
        for (int i = 0; i < numOfLegs; i++)
        {
            table.tableLegs[activeTableLegsNum].transform.GetChild(i).GetComponent<MeshRenderer>().material = table.tableMat[activeMatNum];
            table.tableLegs[activeTableLegsNum].transform.GetChild(i).GetComponent<MeshRenderer>().material.SetFloat("_Metallic", activeSmoothnessVal);
            table.tableLegs[activeTableLegsNum].transform.GetChild(i).GetComponent<MeshRenderer>().material.SetFloat("_Glossiness", activeShininessVal);
        }
    }

    public void ChangeLegsMaterial(float furnishingToolNum, float value)
    {
        int numOfLegs = table.tableLegs[activeTableLegsNum].transform.childCount;
        

        if (furnishingToolNum == 0)
        {
            table.tableHead[activeTableHeadNum].transform.GetComponent<MeshRenderer>().material.SetFloat("_Metallic", value);

            for (int i = 0; i < numOfLegs; i++)
            {
               table.tableLegs[activeTableLegsNum].transform.GetChild(i).GetComponent<MeshRenderer>().material.SetFloat("_Metallic", value);
            }
            activeSmoothnessVal = value;
        }
        if (furnishingToolNum == 1)
        {
            table.tableHead[activeTableHeadNum].transform.GetComponent<MeshRenderer>().material.SetFloat("_Glossiness", value);
            for (int i = 0; i < numOfLegs; i++)
            {
                table.tableLegs[activeTableLegsNum].transform.GetChild(i).GetComponent<MeshRenderer>().material.SetFloat("_Glossiness", value);
            }
            activeShininessVal = value;
        }

       
    }

   
}
