using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnJoueur : MonoBehaviour
{
    [SerializeField] private GameObject joueur;
    // Start is called before the first frame update
    void Start()
    {
        joueur.transform.position = transform.position;
    }
}
