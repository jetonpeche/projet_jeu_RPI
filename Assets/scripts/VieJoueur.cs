using UnityEngine.InputSystem;
using UnityEngine;

public class VieJoueur : MonoBehaviour
{
    [SerializeField] private float vieMax;
    [SerializeField] private BarreDeVie barreDeVie;
    [SerializeField] private Inventaire inventaire;

    private float vieActuelle;

    void Start()
    {
        barreDeVie.SetVieMaxDebut(vieMax);
        vieActuelle = vieMax;
    }

    public void SubirDegats(float _degats)
    {
        vieActuelle -= _degats;
        barreDeVie.BaisserVie(_degats);

        if (vieActuelle <= 0)
        {
            Mort();
        }
    }

    public void OnSoigner()
    {
        SeSoigner(20);
    }

    private void Mort()
    {
        Debug.Log("Mort");
    }

    private void SeSoigner(float _vie)
    {
        if(vieActuelle <  vieMax && inventaire.NbPopSoin > 0)
        {
            inventaire.NbPopSoin--;

            vieActuelle += _vie;
            barreDeVie.MonterVie(_vie);

            if (vieActuelle > vieMax)
            {
                vieActuelle = vieMax;
            }
        }
        
    }
}
