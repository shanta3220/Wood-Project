using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// handles the particle effects and other effects for the gamee
/// </summary>
public class SFXController : MonoBehaviour {
    
	// Use this for initialization

    public static SFXController instance; //allows other scripts to accesss the public methods of this class.
    //public GameObject sfx_coin_pickup; //the particle effect to show when the player picks the coin.



    public Transform key0, key1, key2;
    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    /// <summary>
    /// shows the effects of sparkle when the player collects coin
    /// </summary>
    public void ShowCoinSparkle(Vector3 pos)
    {
      ///  Instantiate(sfx.sfx_coin_pickup, pos, Quaternion.identity);

    }

   
       // Instantiate(sfx.sfx_fragment_1, pos1, Quaternion.identity);
       // Instantiate(sfx.sfx_fragment_2, pos2, Quaternion.identity);
       // Instantiate(sfx.sfx_fragment_2, pos3, Quaternion.identity);
      //  Instantiate(sfx.sfx_fragment_1, pos4, Quaternion.identity);

       
}

