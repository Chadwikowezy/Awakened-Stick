using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player = null;
    float dampenTime = 2.5f;
    public float xAddition;
    public float yAddition;

    private Vector3 playerPos;

    void FixedUpdate()
    {
        playerPos = new Vector3(player.transform.position.x + xAddition, player.transform.position.y + yAddition, this.transform.position.z);

        transform.position = Vector3.Lerp(transform.position, playerPos, Time.deltaTime * dampenTime);
    }
}
