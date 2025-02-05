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

            EnemyHP -= Damage; // HP‚ð‚PŒ¸‚ç‚·
            
            Destroy(other.gameObject);

            if (EnemyHP <= 0)
            {
                int rand = UnityEngine.Random.Range(1, 6);
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
