using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fleche : MonoBehaviour
{
    [SerializeField] private float vitesse = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * vitesse * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
