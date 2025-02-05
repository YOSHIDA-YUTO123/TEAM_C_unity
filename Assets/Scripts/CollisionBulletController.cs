using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBulletController : MonoBehaviour
{
    public int EnemyHP;
    int Damage;
    //public GameObject bulletPrefab;
    public GameObject SpeedItem;
    public GameObject AttackItem;

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
<<<<<<< HEAD
                int rand = UnityEngine.Random.Range(1, 6);
=======
                // �G�t�F�N�g
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

                // �G�t�F�N�g��2�b��ɉ�ʂ������
                Destroy(effect, fTimevalue);

>>>>>>> 6724275daf2a072b803dac492729ec10510e52c5
                gameObject.SetActive(false);
                Destroy(gameObject);

                if(rand == 1)
                {
                    GameObject Item = Instantiate(SpeedItem, transform.position, Quaternion.identity);
                }
                else if(rand == 2)
                {
                    GameObject Item2 = Instantiate(AttackItem, transform.position, Quaternion.identity);
                }
            }

        }
    }
}
