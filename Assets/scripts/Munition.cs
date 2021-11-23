using UnityEngine;
using UnityEngine.UI;

public class Munition : MonoBehaviour
{
    [SerializeField] private Text textFlecheRestante = null;
    private int nbFlecheRestante = 0;

    public int NbFlecheRestante { get => nbFlecheRestante; private set => nbFlecheRestante = value; }

    public void MajFlecheRestante(int _nbFleche)
    {
        NbFlecheRestante = _nbFleche;

        textFlecheRestante.text = $"+ { NbFlecheRestante }";
    }
}
