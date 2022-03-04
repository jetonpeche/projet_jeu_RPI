using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class SetupJoueur : NetworkBehaviour
{

    [SerializeField] private Behaviour[] listeADesactiver;


    // Start is called before the first frame update
    void Start()
    {
        // desactive les objs pour evit� de controller les autres joueurs et entendre leurs son
        if(!isLocalPlayer)
        {
            foreach (var item in listeADesactiver)
            {
                item.enabled = false;
            }
        }
        else
        {
            Camera.main.gameObject.SetActive(false);
        }
    }
}
