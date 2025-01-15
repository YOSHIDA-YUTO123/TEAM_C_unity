using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float MovePow = 0.1f;
    Rigidbody2D rigid2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -MovePow;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * MovePow;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * MovePow;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.up * -MovePow;
        }
    }
}
