using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.05f * Random.value;
        this.rotSpeed = 5.0f + 3.0f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.x < -8.5f || transform.position.y > 9.0f || transform.position.y < -9.0f)
        {
            Destroy(gameObject);
        }
    }
}