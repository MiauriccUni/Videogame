using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCheckpoint : MonoBehaviour
{
    public CheckPoint[] checkPoints;
    public static ControladorCheckpoint intancia;
    public Vector3 spawn; 
    void Awake()
    {
        intancia = this;
    }

    public void desactivarPuntos()
    {
        for (int i = 0; i < checkPoints.Length; i++)
        {
            checkPoints[i].reiniciarPuntos();
        }
    }
    

    private void Start()
    {
        checkPoints = FindObjectsOfType<CheckPoint>();
        spawn = PPlayerController.instancia.transform.position;
    }

    public void cordenadaReSpawn(Vector3 nuevoPuntoSpawn)
    {
        spawn = nuevoPuntoSpawn;
    }
    
}
