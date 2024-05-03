using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public SpriteRenderer SR;
    public Sprite stone, head;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ControladorCheckpoint.intancia.desactivarPuntos();
            SR.sprite = head;
            ControladorCheckpoint.intancia.cordenadaReSpawn(transform.position);
        }
     
    }

    public void reiniciarPuntos()
    {
        SR.sprite = stone;
    }
}
