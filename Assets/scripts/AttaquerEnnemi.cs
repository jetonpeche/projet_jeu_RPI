using UnityEngine;

public class AttaquerEnnemi : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Vector2Int intervalDegat;
    [SerializeField] DeplacementMonstre deplacementMonstre;

    private VieJoueur vieJoueur;

    public void AttaquerCac()
    {
        if(vieJoueur != null)
        {
            int degat = Random.Range(intervalDegat.x, intervalDegat.y);
            vieJoueur.SubirDegats(degat);
        }  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            vieJoueur = collision.GetComponent<VieJoueur>();
            deplacementMonstre.estEntrainAttaquer = true;
            animator.SetBool("attaquer", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            vieJoueur = null;
            deplacementMonstre.estEntrainAttaquer = false;
            animator.SetBool("attaquer", false);
        }
    }
}
