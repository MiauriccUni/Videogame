using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ElevatorTriggerController : MonoBehaviour
{
    private float positionX;

    private float positionY;

    public bool isPlayerOnElevator;

    public bool stopElevator = false;

    [SerializeField]
    float timeToStopElevator = 30;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerOnElevator && !stopElevator)
        {
            timeToStopElevator -= Time.deltaTime;
            this.positionX = transform.position.x;
            this.positionY = transform.position.y;
            transform.position = new Vector3(this.positionX, this.positionY + 6f * Time.deltaTime, 0);

            if (timeToStopElevator <= 0)
            {
                stopElevator = true;
            }
        }   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Debug.Log("triggerererers");
            if (collision.gameObject.CompareTag("StopElevator"))
            {
                stopElevator = !stopElevator;
                Debug.Log("stopping elevator");
            }
        }
    }
}
