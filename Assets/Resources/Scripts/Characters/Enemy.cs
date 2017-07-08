using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animation anim;
    private float speed = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        Vector3 d = GameObject.FindWithTag("Player").transform.position;
        Vector3 s = this.transform.position;
        Vector3 distance = s - d;

        if (distance.x >= .5f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }

        else if (distance.x <= .5f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }

    }

}
