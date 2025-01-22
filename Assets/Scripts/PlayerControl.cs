using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int HP = 100;
    public int ATK = 10;
    public float MovePow = 0.1f;
    public float LimitX = 8.5f;
    public float LimitY = 4.5f;
    public GameObject bulletPrefab;
    Rigidbody2D rigid2D;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 150;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Bullet.GetComponent<BulletControl1>().Damege = GetBulletATK();
        }

        transform.position = new Vector2(
              //ƒGƒŠƒAŽw’è‚µ‚ÄˆÚ“®‚·‚é
              Mathf.Clamp(transform.position.x, -LimitX, LimitX),
              Mathf.Clamp(transform.position.y, -LimitY, LimitY)
              );
    }

    public int GetBulletATK()
    {
        return ATK;
    }
}
