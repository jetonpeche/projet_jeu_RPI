using UnityEngine;
using UnityEngine.InputSystem;

public class Deplacement : MonoBehaviour
{
    [SerializeField] private bool estJoueurDeux;

    [Header("Saut")][Space]
    [SerializeField] private float vitesse;
    [SerializeField] private float forceSaut;
    [Space(20)]

    [SerializeField] private float radius;
    [SerializeField] private LayerMask layerSol;

    [Space(20)]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Transform estAuSolTransform;

    [Space(20)]
    [SerializeField] private Transform t_colliderCaC;

    private bool saute = false;
    private bool estAuSol;
    private float mouvH, mouvV;

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
        FlipX(mouvH);
    }

    public void OnVertical(InputValue _val)
    {
        mouvV = _val.Get<float>();
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
