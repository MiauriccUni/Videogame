using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject pauseScream;
    public bool ispause;
    
    void Update()
    {
        if(Input.GetButtonDown("Menu"))
        {
            pausar(); 
        }
    }

    public void pausar()
    {
        if (ispause)
        {
            ispause = false;
            pauseScream.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            ispause = true;
            pauseScream.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Salir()
    {
        Application.Quit();
    }
}
