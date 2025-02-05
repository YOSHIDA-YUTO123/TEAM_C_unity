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

    public GameObject effectPrefab;// �G�t�F�N�g�v���n�u�p

    public float fTimevalue = 2.0f; // �L������

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

            EnemyHP -= Damage; // HP���P���炷
            
            Destroy(other.gameObject);

            if (EnemyHP <= 0)
            {
                // �G�t�F�N�g
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

                // �G�t�F�N�g��2�b��ɉ�ʂ������
                Destroy(effect, fTimevalue);

                gameObject.SetActive(false);
                Destroy(gameObject);

                GameObject Item = Instantiate(SpeedItem, transform.position, Quaternion.identity);
            }

        }
    }
}
