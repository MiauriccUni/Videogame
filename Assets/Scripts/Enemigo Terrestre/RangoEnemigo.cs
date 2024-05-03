using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemigo : MonoBehaviour
{
    public Animator ani;
    public EnemigoTerrestre enmigo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ani.SetBool("walk",false);
            ani.SetBool("run",false);
            ani.SetBool("ataque",true);
            enmigo.ataque = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}