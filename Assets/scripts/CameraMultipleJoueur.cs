using System.Collections.Generic;
using UnityEngine;

public class CameraMultipleJoueur : MonoBehaviour
{
    [SerializeField] private float smoothTime;
    [SerializeField] private List<Transform> listeJoueur;
    [SerializeField] private Vector3 offset;

    private Vector3 velocite = Vector3.zero;

    private void LateUpdate()
    {
        if (listeJoueur.Count == 0)
            return;

        Vector3 pointCentral = GetPointCentral();
        transform.position = Vector3.SmoothDamp(transform.position, pointCentral + offset, ref velocite, smoothTime);
    }

    private Vector3 GetPointCentral()
    {
        if (listeJoueur.Count == 1)
            return listeJoueur[0].position;

        Bounds bounds = new Bounds(listeJoueur[0].position, Vector3.zero);

        for (int i = 0; i < listeJoueur.Count; i++)
        {
            bounds.Encapsulate(listeJoueur[i].position);
        }

        return bounds.center;
    }
}
