using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private int BulletPattern = 2;
    public int HP = 100;
    public int ATK = 10;
    public int BulletMode = 0;
    public float MovePow = 0.1f;
    public float LimitX = 8.5f;
    public float LimitY = 4.5f;
    public float shotAngle = 15f; // 弾が開く角度
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
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
            if(BulletMode % BulletPattern == 0)
            {
                GameObject Bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                Bullet.GetComponent<BulletControl1>().Damege = GetBulletATK();
            }
            else if (BulletMode % BulletPattern == 1)
            {
                GameObject Bullet = Instantiate(bulletPrefab2, transform.position, transform.rotation * Quaternion.Euler(0, 0, shotAngle));
                Bullet.GetComponent<BulletControl2>().Damege = GetBulletATK() / 2;

                GameObject Bullet2 = Instantiate(bulletPrefab2, transform.position, transform.rotation * Quaternion.Euler(0, 0, -shotAngle));
                Bullet2.GetComponent<BulletControl2>().Damege = GetBulletATK() / 2;

                GameObject Bullet3 = Instantiate(bulletPrefab2, transform.position, Quaternion.identity);
                Bullet3.GetComponent<BulletControl2>().Damege = GetBulletATK() / 2;
            }
        }

        transform.position = new Vector2(
              //エリア指定して移動する
              Mathf.Clamp(transform.position.x, -LimitX, LimitX),
              Mathf.Clamp(transform.position.y, -LimitY, LimitY)
              );
    }

    public int GetBulletATK()
    {
        return ATK;
    }
}
