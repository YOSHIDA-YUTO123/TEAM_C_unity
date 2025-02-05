using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBulletController : MonoBehaviour
{
    public int EnemyHP;
    int Damage;
    int Random;
    //public GameObject bulletPrefab;
    public GameObject SpeedItem;

    public GameObject effectPrefab;// エフェクトプレハブ用

    public float fTimevalue = 2.0f; // 有効時間

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            GameObject pl = GameObject.Find("Player");

            PlayerControl playerControl = pl.GetComponent<PlayerControl>();
            Damage = playerControl.GetBulletATK();

            EnemyHP -= Damage; // HPを１減らす
            
            Destroy(other.gameObject);

            if (EnemyHP <= 0)
            {
                // エフェクト
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

                // エフェクトを2秒後に画面から消す
                Destroy(effect, fTimevalue);

                gameObject.SetActive(false);
                Destroy(gameObject);

                GameObject Item = Instantiate(SpeedItem, transform.position, Quaternion.identity);
            }

        }
    }
}
