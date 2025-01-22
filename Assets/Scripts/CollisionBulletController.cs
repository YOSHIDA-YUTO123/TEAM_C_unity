using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBulletController : MonoBehaviour
{
    public int EnemyHP;

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
            EnemyHP -= 1; // HP‚ð‚PŒ¸‚ç‚·

            Destroy(other.gameObject);

            if (EnemyHP == 0)
            {
                gameObject.SetActive(false);
            }
        }

    }
}
