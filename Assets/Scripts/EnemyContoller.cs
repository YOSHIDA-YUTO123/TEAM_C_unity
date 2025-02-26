using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoller : MonoBehaviour
{
    // 移動速度
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

        // 移動
        move();

        if (rb.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void move()
    {
        rb.velocity = new Vector2(-rb.velocity.x, -speed);
    }
}
