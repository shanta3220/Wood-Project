using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeFalls : MonoBehaviour {
    Animator anim;
    public Transform endTrans;
    public float delay;
	// Use this for initialization
	void Awake () {
        
       
    }

    public void SetupTreeAnimation()
    {
       
        Invoke("TreeFalling", delay);
        transform.position = endTrans.position;
        transform.rotation = endTrans.rotation;
        
    }

	void TreeFalling()
    {
        anim.SetBool("Fall", true);
       
    }

    public void ResetTreeAnimation()
    {


        anim = GetComponent<Animator>();
        anim.SetBool("Fall", false);

    }






}
