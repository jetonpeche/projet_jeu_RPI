using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreDeVie : MonoBehaviour
{
    public Slider sliderVie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BaisserVie(float degats)
    {
        sliderVie.value -= degats;        
    }

    public void MonterVie(float vieAjout)
    {
        sliderVie.value += vieAjout;
    }
}
