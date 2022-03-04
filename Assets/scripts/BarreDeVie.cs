using UnityEngine;
using UnityEngine.UI;

public class BarreDeVie : MonoBehaviour
{
    public Slider sliderVie;

    public void BaisserVie(float degats)
    {
        sliderVie.value -= degats;
    }

    public void MonterVie(float vieAjout)
    {
        sliderVie.value += vieAjout;
    }

    public void SetVieMaxDebut(float _vieMax)
    {
        sliderVie.maxValue = _vieMax;
        sliderVie.value = _vieMax;
    }
}
