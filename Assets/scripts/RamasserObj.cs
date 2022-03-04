using UnityEngine;

public class RamasserObj : MonoBehaviour
{
    [SerializeField]
    private Vector2Int intervalFlecheGenerer;
    [SerializeField] private Inventaire inventaire;


    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.transform.tag)
        {
            case "munition":
                if(!inventaire.ReserveMunitionPleine())
                {
                    Munition mun = col.GetComponent<Munition>();

                    // premiere entrer sur les munitions
                    if(mun.NbFlecheRestante == 0)
                    {
                        int nbFleche = Random.Range(intervalFlecheGenerer.x, intervalFlecheGenerer.y);
                        mun.MajFlecheRestante(inventaire.AjouterFleche(nbFleche));
                    }
                    else
                    {
                        mun.MajFlecheRestante(inventaire.AjouterFleche(mun.NbFlecheRestante));
                    }          

                    if(mun.NbFlecheRestante == 0)
                        Destroy(col.gameObject);
                }
                break;

            case "popoSoin":
                inventaire.NbPopSoin++;
                Destroy(col.gameObject);
                break;

            case "popoMana":
                inventaire.NbPopMana++;
                Destroy(col.gameObject);
                break;
        }
    }
}
