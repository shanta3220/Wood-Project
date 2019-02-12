using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingAnimationController : MonoBehaviour
{

    Animator anim;
    public int ObjectNum;
    public float delay;




    public void CanCut()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("StopCutting", false);
        Invoke("StopCutting", delay);

    }

    public void StopCutting()
    {
        anim.SetBool("StopCutting", true);
    }
}
    
