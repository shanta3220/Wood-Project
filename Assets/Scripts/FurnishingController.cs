using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnishingController : MonoBehaviour
{
    Slider slider;
    public float sliderNum;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void Furnishing()
    {
        GameController.instance.ChangeLegsMaterial(sliderNum, slider.value);

    }

   
}
