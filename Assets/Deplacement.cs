using UnityEngine;

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

    private bool saute = false;
    private bool estAuSol;
    private string axeX, jump;

    private void Start()
    {
        if (estJoueurDeux)
        {
            axeX = "Horizontal2";
            jump = "Jump2";
        }
        else
        {
            axeX = "Horizontal";
            jump = "Jump";
        }
    }

    // Update is called once per frame
    void Update()
    {
        float mouvH = Input.GetAxis(axeX) * vitesse * Time.deltaTime;

        transform.Translate(new Vector2(mouvH, 0));
        animator.SetFloat("vitesseMarche", Mathf.Abs(mouvH));

        FlipX(mouvH);
        Sauter();
    }

    private void FixedUpdate()
    {
        estAuSol = Physics2D.OverlapCircle(estAuSolTransform.position, radius, layerSol);
    }

    private void Sauter()
    {
        if (estAuSol && Input.GetButtonDown(jump))
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
        if (_mouvH < 0)
            spriteRenderer.flipX = true;
        else if (_mouvH > 0)
            spriteRenderer.flipX = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(estAuSolTransform.position, radius);
    }
}
