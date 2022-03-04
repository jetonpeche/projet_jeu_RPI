using UnityEngine;

public class AttaqueAnim : MonoBehaviour
{
    [SerializeField] private AttaquerEnnemi attaquerEnnemi;

    public void DeclancherAttaqueCac()
    {
        attaquerEnnemi.AttaquerCac();
    }

    public void DeclancherAttaqueDistance()
    {

    }
}
