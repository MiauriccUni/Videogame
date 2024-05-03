
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemigoTerrestre: MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator ani;
    public int direccion;
    public float VWalk;
    public float VRun;
    public GameObject target;
    
    public bool ataque;
    
    public float rAtaque;
    public float rFVision;
    
    public GameObject rango;
    public GameObject golpe;
    void Start()
    {
        ani.GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        comportamiento();
    }

    public void comportamiento()
    {
        if (Mathf.Abs(transform.position.x - target.transform.position.x) > rFVision && !ataque)
        {
            ani.SetBool("run",false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 2)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    ani.SetBool("walk",false);
                    break;
                case 1:
                    direccion = Random.Range(0, 2);
                    rutina++;
                    break;
                case 2:
                    switch (direccion)
                    {
                        case 0:
                            transform.rotation = Quaternion.Euler(0,0,0);
                            transform.Translate(Vector3.right*VWalk*Time.deltaTime);
                            break;
                        case 1:
                            transform.rotation = Quaternion.Euler(0,180,0);
                            transform.Translate(Vector3.right*VWalk*Time.deltaTime);
                            break;
                    } ani.SetBool("walk",true);
                    break;
            }
        }
        else
        {
            if (Mathf.Abs(transform.position.x - target.transform.position.x) > rAtaque && !ataque)
            {
                if (transform.position.x < target.transform.position.x)
                {
                    ani.SetBool("walk", false);
                    ani.SetBool("run",true);
                    transform.Translate(Vector3.right*VRun*Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0,0,0);
                    ani.SetBool("ataque",false);
                }
                else
                {
                    ani.SetBool("walk", false);
                    ani.SetBool("run",true);
                    transform.Translate(Vector3.right*VRun*Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0,180,0);
                    ani.SetBool("ataque",false);
                }
            }
            else
            {
                if (!ataque)
                {
                    if (transform.position.x < target.transform.position.x)
                    {
                        transform.rotation = Quaternion.Euler(0,0,0);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(0,180,0);  
                    }
                    ani.SetBool("walk",false);
                    ani.SetBool("run",false);
                }
            }
            
        }
    }

    public void animacionFinal()
    {
        ani.SetBool("ataque",false);
        ataque = false;
        rango.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void Colision()
    {
        golpe.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void noColision()
    {
        golpe.GetComponent<BoxCollider2D>().enabled = false;
    }
}
