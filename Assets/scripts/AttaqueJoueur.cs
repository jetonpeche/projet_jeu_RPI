using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttaqueJoueur : MonoBehaviour
{
    [SerializeField] [Min(1)] private float degatCaC;
    [SerializeField] [Min(1)] private float degatDistance;

    [Space(20)]
    [SerializeField] private float couldownAttaqueCaC;
    [SerializeField] private float couldownAttaqueDistance;
     
    [Space(20)]
    [SerializeField] private LayerMask layerEnnemi;
    [SerializeField] private BoxCollider2D col;
    [SerializeField] private Animator animator;


    public bool possedeArmeCaC = true;

    private bool peuAttaquerCaC = true;
    private bool peuAttaquerDistance = true;

    // event de l'input systeme point d'entrer pour l'attaque
    public void OnAttaquer()
    {
        if (possedeArmeCaC)
            AttaquerCaC();
        else
            AttaquerDistance();
    }

    private void AttaquerCaC()
    {
        if(peuAttaquerCaC)
        {
            animator.SetTrigger("attaqueCaC");
            StartCoroutine(CouldownAttaqueCaC());
        }
    }

    private void AttaquerDistance()
    {
        if (peuAttaquerDistance)
        {
            animator.SetTrigger("attaqueDistance");
            StartCoroutine(CouldownAttaqueDistance());
        }
    }

    private IEnumerator CouldownAttaqueDistance()
    {
        peuAttaquerCaC = false;
        yield return new WaitForSeconds(couldownAttaqueDistance);
        peuAttaquerCaC = true;
    }

    private IEnumerator CouldownAttaqueCaC()
    {
        peuAttaquerDistance = false;
        yield return new WaitForSeconds(couldownAttaqueCaC);
        peuAttaquerDistance = true;
    }
}
