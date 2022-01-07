using UnityEngine;
using UnityEngine.InputSystem;
using Mirror;

public class Deplacement : NetworkBehaviour
{
    [Header("Saut")]
    [SerializeField] private float vitesse;
    [SerializeField] private float forceSaut;

    [Space(20)]
    [SerializeField] private float radius;
    [SerializeField] private LayerMask layerSol;

    [Space(20)]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private NetworkAnimator netAnimator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Transform estAuSolTransform;
    [SerializeField] private AttaqueJoueur attaqueJoueur;

    [Space(20)]
    [SerializeField] private Transform t_colliderCaC;

    private bool saute = false;
    private bool estAuSol;

    private float mouvH, mouvHActuel;


    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector2(mouvH, 0) * vitesse * Time.deltaTime);
        animator.SetFloat("bouger", Mathf.Abs(mouvH));
    }

    private void FixedUpdate()
    {
        estAuSol = Physics2D.OverlapCircle(estAuSolTransform.position, radius, layerSol);
    }

    public void OnHorizontal(InputValue _val)
    {
        mouvH = _val.Get<float>();

        // evite d'appeler la fonction pour rien
        if (mouvH == mouvHActuel)
            return;

        mouvHActuel = mouvH;
        CMD_FlipX(mouvH);
    }

    public void OnSauter()
    {
        if (estAuSol)
        {
            saute = true;
        }

        if (saute)
        {
            rb.AddForce(new Vector2(0, forceSaut));
            saute = false;
        }
    }

    // fonction envoyer au serveur pour les autres joueurs
    [Command]
    private void CMD_FlipX(float _mouvH)
    {
        FlipX(_mouvH);   
    }

    // fonction joueur local pour que tout les joueurs voit les changements
    [ClientRpc]
    private void FlipX(float _mouvH)
    {
        switch (_mouvH)
        {
            case -1:
                spriteRenderer.flipX = true;
                break;

            case 1:
                spriteRenderer.flipX = false;
                break;
        }

        FlipXColliderCaC(spriteRenderer.flipX);
        attaqueJoueur.SetTransformPointSpawnFleche(spriteRenderer.flipX);

    }

    private void FlipXColliderCaC(bool _etat)
    {
        t_colliderCaC.eulerAngles = _etat ? new Vector3(t_colliderCaC.eulerAngles.x, 180) : new Vector3(t_colliderCaC.eulerAngles.x, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(estAuSolTransform.position, radius);
    }
}
