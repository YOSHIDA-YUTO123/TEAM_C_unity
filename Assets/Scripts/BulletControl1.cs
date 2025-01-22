using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl1 : MonoBehaviour
{
    public float BulletSpeed = 0.1f;
    public int Damege = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(BulletSpeed, 0.0f, 0);

        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
}
