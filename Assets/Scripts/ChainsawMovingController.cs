using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainsawMovingController : MonoBehaviour
{
    public Transform target;
    public Transform firstCut, secondCut, thirdCut, secondCutDown, thirdCutDown;
    public int movingModel;
    public float speed;
    public Transform log1, log2;
    public Transform log1Target, log2Target;
    public Transform log1Part1, log1Part2;
    public Transform log1Part1Target, log1Part2Target;
    bool canMovel;
    float wait;
    bool firstAnim = true;
    bool secondAnim = false;
    bool thirdAnim = false;
    bool firstMoveDone = false, secondMoveDone;

    // Update is called once per frame

    private void Start()
    {
        /*log1.transform.GetComponent<ChainsawMovingController>().enabled = false;
        log2.transform.GetComponent<ChainsawMovingController>().enabled = false;*/
    }
    void FixedUpdate()
    {
        if (movingModel == 0)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            
        }
        if (!firstMoveDone)
        {
            if (transform.position == firstCut.position && firstAnim)
            {
                MoveTree(log2);
                wait += Time.deltaTime;
                if (wait >= 2)
                {
                    MoveTree(log1);
                    if (log1.rotation == log1Target.rotation)
                    {
                        firstAnim = false;
                        wait = 0;
                    }
                }
            }
            if (!firstAnim)
            {
                target = secondCut;
                speed = 2;
                wait += Time.deltaTime;
                if (wait >= 3)
                {
                    speed = 1;
                    target = secondCutDown;
                    if (transform.position == target.position)
                    {
                        secondAnim = true;
                        firstMoveDone = true;
                        wait = 0;
                    }
                }
            }

        }
        if (!secondMoveDone)

        {
            if (transform.position == secondCutDown.position && secondAnim)
            {
                MoveParts(log1Part1);
                if (log1Part1.position == log1Part1Target.position)
                {
                    secondAnim = false;
                    target = thirdCut;
                    

                }
            }

            if (transform.position == thirdCut.position)
            {
                wait += Time.deltaTime;
                Debug.Log(wait);
                if (wait >= 1)
                {
                    speed = 2;
                    target = thirdCutDown;
                    if (transform.position == target.position)
                    {
                        thirdAnim = true;
                        firstMoveDone = true;
                        wait = 0;
                    }
                }
            }

            if (transform.position == thirdCutDown.position)
            {
                MoveParts(log1Part2);
                if(log1Part2 == log1Part2Target)
                    secondMoveDone = true;
            }

        }
        
    }

    public void MoveTree(Transform log)
    {
        if(log == log2)
        {
            log2.transform.position = Vector3.MoveTowards(log2.transform.position, log2Target.position, 2*Time.deltaTime);
        }

        if (log == log1)
        {
            
            log1.transform.position = Vector3.MoveTowards(log1.transform.position, log1Target.position, 2 * Time.deltaTime);
            log1.transform.rotation = Quaternion.RotateTowards(log1.transform.rotation, log1Target.rotation, 45 * Time.deltaTime);
        }
    }

    public void MoveParts(Transform logPart)
    {
        if (logPart == log1Part1)
        {
            log1Part1.transform.position = Vector3.MoveTowards(log1Part1.transform.position, log2Target.position, 2 * Time.deltaTime);
        }

        if (logPart == log1Part2)
        {

            log1Part2.transform.position = Vector3.MoveTowards(log1Part2.transform.position, log1Part2Target.position, 2 * Time.deltaTime);
            
        }
    }
}
