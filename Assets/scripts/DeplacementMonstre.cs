using UnityEngine;

public class DeplacementMonstre : MonoBehaviour
{
    [HideInInspector]
    public bool estEntrainAttaquer = false;

    [SerializeField] private Transform[] listePt;
    [SerializeField] private float vitesse;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Transform zoneAttaque;

    private Vector3 ptDestination;
    private int index = 0;

    private void Start()
    {
        ptDestination = listePt[index].position;

        spriteRenderer.flipX = transform.position.x > ptDestination.x;

        RotationZoneDetection();
    }

    private void Update()
    {
        if(estEntrainAttaquer)
            return;

        // se deplacer a la position defini
        transform.position = Vector3.MoveTowards(transform.position, ptDestination, vitesse * Time.deltaTime);

        // changer le point de destination
        if(Vector3.Distance(transform.position, ptDestination) < 0.2f)
        {
            index = (index + 1) % listePt.Length;
            ptDestination = listePt[index].position;

            spriteRenderer.flipX = !spriteRenderer.flipX;

            RotationZoneDetection();
        }
    }

    private void RotationZoneDetection()
    {
        Quaternion rotation = transform.rotation;

        rotation.y = spriteRenderer.flipX ? 180 : 0;
        zoneAttaque.rotation = rotation;
    }
}
