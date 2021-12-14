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
    [SerializeField] private BoxCollider2D zoneAttaqueCaC;
    [SerializeField] private Animator animator;

    [Space(20)]
    [SerializeField] private RuntimeAnimatorController animControlleurCaC;
    [SerializeField] private RuntimeAnimatorController animControlleurDistance;

    private bool peuAttaquerCaC = true;
    private bool peuAttaquerDistance = true;

    public void OnAttaquer()
    {
        if (peuAttaquerCaC)
        {
            animator.SetTrigger("attaqueCaC");
            StartCoroutine(CouldownAttaqueCaC());
        }
    }

    public void OnAttaquerDistance()
    {
        if (peuAttaquerDistance)
        {
            animator.SetTrigger("attaqueDistance");
            StartCoroutine(CouldownAttaqueDistance());
        }
    }

    private IEnumerator CouldownAttaqueDistance()
    {
        peuAttaquerDistance = false;
        yield return new WaitForSeconds(couldownAttaqueDistance);
        peuAttaquerDistance = true;
    }

    private IEnumerator CouldownAttaqueCaC()
    {
        peuAttaquerCaC = false;
        yield return new WaitForSeconds(couldownAttaqueCaC);
        peuAttaquerCaC = true;
    }
}
