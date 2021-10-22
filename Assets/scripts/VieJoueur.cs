using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VieJoueur : MonoBehaviour
{
    public float vieActuelle;
    public float vieMax;
    public BarreDeVie barreDeVie;
    // Start is called before the first frame update
    void Start()
    {
        barreDeVie.sliderVie.maxValue = vieMax;
        vieActuelle = vieMax;
    }

    public void SubirDegats(float degats)
    {
        vieActuelle -= degats;
        barreDeVie.BaisserVie(degats);
        if(vieActuelle <= 0)
        {
            Mort();
        }
    }

    private void Mort()
    {
        Debug.Log("Mort");
    }

    public void SeSoigner(float vie)
    {
        vieActuelle += vie;
        barreDeVie.MonterVie(vie);
        if (vieActuelle > vieMax)
        {
            vieActuelle = vieMax;
        }
    }
}
