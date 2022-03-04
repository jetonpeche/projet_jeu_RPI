using UnityEngine;

public class Fleche : MonoBehaviour
{
    [SerializeField] private float vitesse = 5f;
    [HideInInspector] public int degat;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * vitesse * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }


        if(collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<VieJoueur>().SubirDegats(degat);
            Destroy(gameObject);
        }
    }
}
