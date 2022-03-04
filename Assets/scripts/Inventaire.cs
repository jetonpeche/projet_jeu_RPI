using UnityEngine;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour
{
    [SerializeField] private Text textMunition = null;
    [SerializeField] private Text textPopSoin = null;
    [SerializeField] private Text textPopMana = null;

    public int nbMunition = 40;
    public int nbMunitionMax = 40;
    private int nbPopSoin = 3;
    private int nbPopMana = 3;

    public int NbMunition { get => nbMunition; private set => nbMunition = value; }
    public int NbPopSoin 
    { 
        get => nbPopSoin;
        set
        {
            nbPopSoin = value;
            textPopSoin.text = NbPopSoin.ToString();
        }
    }
    public int NbPopMana 
    { 
        get => nbPopMana;
        set
        {
            nbPopMana = value;
            textPopMana.text = NbPopMana.ToString();
        }
    }

    void Start()
    {
        textMunition.text = NbMunition.ToString();
        textPopSoin.text = NbPopSoin.ToString();
        textPopMana.text= NbPopMana.ToString();
    }

    public bool ReserveMunitionPleine()
    {
        return NbMunition == nbMunitionMax;
    }

    /// <summary>
    /// Ajoute les fleche dans la reserve de munition
    /// </summary>
    /// <returns>Le nombre de munition pas utilisé</returns>
    public int AjouterFleche(int _nbFleche)
    {
        int nbMunitionTotal = NbMunition += _nbFleche;
        
        if (nbMunitionTotal > nbMunitionMax)
        {
            int nbMunitionEnlever = nbMunitionTotal - nbMunitionMax;

            NbMunition -= nbMunitionEnlever;
            textMunition.text = NbMunition.ToString();

            return _nbFleche - nbMunitionEnlever;
        }
            
        textMunition.text = NbMunition.ToString();

        return 0;
    }
}
