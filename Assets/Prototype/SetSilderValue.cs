using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSilderValue : MonoBehaviour
{
    public Slider slider;

    public void changeSliderValue() {
        slider.value = Random.Range(0, 100);
        Debug.Log(slider.value);
    }
}
