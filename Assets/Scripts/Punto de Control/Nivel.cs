using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel : MonoBehaviour
{
    public static Nivel instancia;

    public float esperaSpawn;

    private void Awake()
    {
        instancia = this;
    }

    public void revivirJugador()
    {
        StartCoroutine(revivirCo());
    }

    IEnumerator revivirCo()
    {
        yield return new WaitForSeconds(esperaSpawn);
        ControladorVidas.instancia.gameObject.SetActive(false);
        yield return new WaitForSeconds(esperaSpawn);
        ControladorVidas.instancia.gameObject.SetActive(true);
        ControladorVidas.instancia.transform.position = ControladorCheckpoint.intancia.spawn;
    }
}
