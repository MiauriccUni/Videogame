using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform target;
    public Transform background;
   // public float minHeight, maxHeight;
    private Vector2 lastPos;
    public float FollowSpeed = 2f;
    
    void Start()
    {
        lastPos = transform.position;
    }
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed);
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
        // // transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, minHeight, maxHeight),target.position.z);
        //
        Vector2 amountToMove = new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);
        background.position = background.position + new Vector3(amountToMove.x, amountToMove.y, 0f);
        //
        lastPos = transform.position;

    }
}
