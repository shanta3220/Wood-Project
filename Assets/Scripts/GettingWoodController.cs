using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingWoodController : MonoBehaviour {
    Animator anim;
    RuntimeAnimatorController ac;
    public float delay = 10.01667f;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        ac = anim.runtimeAnimatorController;
        AnimationLenthOfWoodProcess();
    }

    public void SetupAnimation()
    {
        anim = GetComponent<Animator>();
        delay = 13.5f;
        anim.SetBool("CanAnimate", true);
        Invoke("ShowSparkle", delay-2f);
        Invoke("ResetTreeAnimation", delay);
        
    }
    public void ShowSparkle()
    {
        GameController.instance.ShowSparkle();
        AudioController.instance.GettingWoodProcessAudio();
    }

   
    public void ResetTreeAnimation()
    {

        anim.SetBool("CanAnimate", false);
        gameObject.SetActive(false);
        ActivateTableEditorTools();

    }

    public void AnimationLenthOfWoodProcess()
    {
        for (int i = 0; i < ac.animationClips.Length; i++)                 //For all animations
        {
            if (ac.animationClips[i].name == "GettingWoodProcess")        //If it has the same name as your clip
            {
                delay = ac.animationClips[i].length;
            }
        }
    }

    public void ActivateTableEditorTools()
    {
        GameController.instance.EnableEditorTool();
        GameController.instance.ChangeEditorTool(0);
        GameController.instance.ChangeTableHead(0);
        GameController.instance.ChangeTableLegs(0);
        GameController.instance.ChangeTableMaterial(0);
    }
}
