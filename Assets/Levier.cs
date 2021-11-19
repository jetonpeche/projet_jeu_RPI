using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Levier : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private bool estActive = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Collision levier");
            if (Keyboard.current.eKey.isPressed)
            {
                Debug.Log("E Key Levier");
                if (estActive)
                {
                    animator.Play("LevierGaucheDroite");
                    estActive = false;
                }
                else
                {
                    animator.Play("LevierDroiteGauche");
                    estActive = true;
                }
            }
        }
    }
}
