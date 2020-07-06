using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ManaBar : MonoBehaviour
{

    public Slider Mslider;


    public void SetMana(int mana)
    {
        Mslider.value = mana;
    }

    public void SetMaxMana(int mana)
    {
        Mslider.maxValue = mana;
        Mslider.value = mana;
    }
}
