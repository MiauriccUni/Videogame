using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30f;
    public Rigidbody2D rb;
    public int damamage = 10;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D objetoInfo)
    {
        EnemigoB enemy = objetoInfo.GetComponent<EnemigoB>();
        if (enemy!= null)
        {
            enemy.TakeDamage(damamage);
        }
        Destroy(gameObject);
    }
}
