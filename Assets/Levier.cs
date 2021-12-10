using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Levier : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private bool estActive = false;
    private bool estDansZone = false;

    private void Update()
    {
        if(estDansZone)
        {
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                Declencher();
            }
        }
    }

    private void Declencher()
    {
        if (!estActive)
        {
            animator.Play("LevierDroiteGauche");
            estActive = true;
        }
        else
        {
            animator.Play("LevierGaucheDroite");
            estActive = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            estDansZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            estDansZone = false;
        }
    }
}