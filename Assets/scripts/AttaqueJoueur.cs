using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class AttaqueJoueur : NetworkBehaviour
{
    [SerializeField] private GameObject flechePrefab;
    [SerializeField] private Transform t_ptSpawnFleche;
    [SerializeField] private SpriteRenderer spriteRenderer;

    [Space(20)]
    [SerializeField] [Min(1)] private float degatCaC;
    [SerializeField] [Min(1)] private float degatDistance;

    [Space(20)]
    [SerializeField] private float couldownAttaqueCaC;
    [SerializeField] private float couldownAttaqueDistance;
     
    [Space(20)]
    [SerializeField] private LayerMask layerEnnemi;
    [SerializeField] private BoxCollider2D zoneAttaqueCaC;
    [SerializeField] private Animator animator;

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

    public void SetTransformPointSpawnFleche(bool _etatFlipX)
    {

        if(_etatFlipX)
        {
            t_ptSpawnFleche.localPosition = new Vector3(0.065f, 0.06f, 0);
            t_ptSpawnFleche.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            t_ptSpawnFleche.localPosition = new Vector3(-0.06f, 0.06f, 0);
            t_ptSpawnFleche.eulerAngles = Vector3.zero;
        }
    }

    // declancher depuis l'animator
    private void LancerFleche()
    {
        Instantiate(flechePrefab, t_ptSpawnFleche.position, t_ptSpawnFleche.rotation);
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
