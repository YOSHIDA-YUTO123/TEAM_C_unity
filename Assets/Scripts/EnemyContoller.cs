using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoller : MonoBehaviour
{
    // ˆÚ“®‘¬“x
    public float speed = 2.0f;

    // Rigidbody
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        // ˆÚ“®
        move();

        //if(rb.transform.position.y < )
    }

    private void move()
    {
        rb.velocity = new Vector2(-rb.velocity.x, -speed);
    }
}
