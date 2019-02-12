using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// AI Engine of Bomber Bee
/// </summary>
public class BomberBeeAI : MonoBehaviour
{

    public float destroyBeeDelay;           //how long to wait before bee is destroyed
    public float beeSpeed;                       //  speed at which bee moves
    public float beeDamage;
    public float enemyHealth;

    

    public void ActivateBee(Vector3 PlayerPos)
    {
        transform.DOMove(PlayerPos, beeSpeed, false);
    }

  
}
