using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasserObj : MonoBehaviour
{
    [SerializeField]
    private Vector2Int intervalFlecheGenerer;


    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.transform.tag)
        {
            case "munition":
                if(!Inventaire.instance.ReserveMunitionPleine())
                {
                    Munition mun = col.GetComponent<Munition>();

                    // premiere entrer sur les munitions
                    if(mun.NbFlecheRestante == 0)
                    {
                        int nbFleche = Random.Range(intervalFlecheGenerer.x, intervalFlecheGenerer.y);
                        mun.MajFlecheRestante(Inventaire.instance.AjouterFleche(nbFleche));
                    }
                    else
                    {
                        mun.MajFlecheRestante(Inventaire.instance.AjouterFleche(mun.NbFlecheRestante));
                    }          

                    if(mun.NbFlecheRestante == 0)
                        Destroy(col.gameObject);
                }
                break;

            case "popoSoin":
                Inventaire.instance.NbPopSoin++;
                Destroy(col.gameObject);
                break;

            case "popoMana":
                Inventaire.instance.NbPopMana++;
                Destroy(col.gameObject);
                break;
        }
    }
}
