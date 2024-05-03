using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float followSpeed = 3f;

    private float startPosX;
    private float startPosY;
    // follow background speed
    public float backgroundSpeedX = 0.95f;
    public float backgroundSpeedY = 1f;

    public float caveRockSpeed = 0.1f;

    // background variables
    public Transform background;
    public Transform caveRocks;

    public static bool touchingParallaxBackgroundArea = false; 
    // Start is called before the first frame update
    void Start()
    {
        startPosX = transform.position.x;
        startPosY = transform.position.y;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 newPos = new Vector3(player.position.x, player.position.y, -7f);
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);

        if (!touchingParallaxBackgroundArea)
        {
            return;
        }

        float distance = (transform.position.x * backgroundSpeedX);
        background.transform.position = new Vector3(startPosX + distance, background.transform.position.y, background.transform.position.z);

        distance = (transform.position.y * backgroundSpeedY);
        background.transform.position = new Vector3(background.transform.position.x, startPosY + distance, background.transform.position.z);

    }
}
