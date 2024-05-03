using System;
using UnityEngine;

namespace Enemigo_Terrestre
{
    public class GolpeEnemigo : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                ControladorVidas.instancia.dealDamage();
            }
        }
    }
}