using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaqueDePression : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private bool estDansZone = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            estDansZone = true;
            animator.Play("PlaquePressionActivee");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            estDansZone = false;
            animator.Play("PlaquePressionDesactivee");
        }
    }
}
