using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levier : MonoBehaviour
{
    public bool estActive = false;
    public Animator animator;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (estActive)
        {
            animator.Play("LevierGaucheDroite");
        }
        else
        {
            animator.Play("LevierDroiteGauche");
        }
    }
}
