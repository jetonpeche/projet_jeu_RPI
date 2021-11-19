using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class FeuDeCamp : MonoBehaviour
{
    [SerializeField] private Animator animator = null;
    [SerializeField] private GameObject obj = null;
    [SerializeField] private Transform transformPtSpawn = null;

    private bool estActive = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player" && !estActive)
        {
            if (Keyboard.current.eKey.isPressed)
            {
                Instantiate(obj, transformPtSpawn.position, transformPtSpawn.rotation);
                estActive = true;
                Destroy(transformPtSpawn.gameObject);
            }
        }
    }
}
