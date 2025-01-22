using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCastle : MonoBehaviour
{
    // 城と敵の当たり判定
    public int CastleLife = 100; // 城体力
    public int nDamege = 2;      // ダメージ量

    public GameObject effectPrefab;// エフェクトプレハブ用

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
        // 敵との衝突
        if (other.gameObject.CompareTag("Enemy"))
        {
            // 体力を減らす
            CastleLife -= nDamege;

            // 当たったら
            Destroy(other.gameObject);

            if (CastleLife > 0)
            {// 体力が0以上
                // エフェクト
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

                // エフェクトを4秒後に画面から消す
                Destroy(effect, 4.0f);
            }

            if (CastleLife <= 0)
            {// 体力が0以下
                // 城なくなる
                gameObject.SetActive(false);
            }

        }
    }

}

