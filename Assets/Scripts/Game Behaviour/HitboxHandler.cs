using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxHandler : MonoBehaviour
{
    // Start is called before the first frame update
    // movement of the player variables
    public float speed = 5f;
    public float jumpForce = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movement of the player
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        Debug.Log("Hit");
        if (col.gameObject.tag == "Ground")
        {
            Debug.Log("Hit");
        }
    }
}
