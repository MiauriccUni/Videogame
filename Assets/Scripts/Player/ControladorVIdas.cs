using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVidas : MonoBehaviour
{
    public static ControladorVidas instancia;
    public int currentHealth, maxHealth;
    // Start is called before the first frame update
    private void Awake()
    {
        instancia = this;
    }
    void Start()
    {
        // currentHealth = maxHealth;
    }
    public void dealDamage()
    {
        maxHealth--;
        if (maxHealth <= 0)
        {
          Nivel.instancia.revivirJugador();
        }
    }
}
