﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerater24 : MonoBehaviour
{
    public GameObject enemyPrefab; // 敵のPrefab
    public float BasespawnInterval = 2.0f; // 敵を出現させる間隔（秒）
    public int nBaseHP = 30;
    public int StartLevel = 0;
    public int AddLevel = 0;
    public int Level = 0;
    public Vector2 spawnAreaMin; // スポーンエリアの左下の座標
    public Vector2 spawnAreaMax; // スポーンエリアの右上の座標

    private float timer;

    void Start()
    {
        Level = StartLevel;
        timer = BasespawnInterval - (Level * 0.1f); // タイマーを初期化
    }

    void Update()
    {
        timer -= Time.deltaTime;
        Level = AddLevel + StartLevel;
        if (timer <= 0f)
        {
            SpawnEnemy();
            timer = BasespawnInterval - (Level * 0.1f); // タイマーをリセット
        }
    }

    void SpawnEnemy()
    {
        // ランダムな位置を計算
        float randomX = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float randomY = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        Vector2 spawnPosition = new Vector2(randomX, randomY);

        // 敵を生成
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        enemyPrefab.GetComponent<CollisionBulletController>().EnemyHP = nBaseHP + (Level * 10);
    }

    void OnDrawGizmosSelected()
    {
        // スポーンエリアを視覚化
        Gizmos.color = Color.green;
        Gizmos.DrawLine(new Vector2(spawnAreaMin.x, spawnAreaMin.y), new Vector2(spawnAreaMax.x, spawnAreaMin.y));
        Gizmos.DrawLine(new Vector2(spawnAreaMin.x, spawnAreaMin.y), new Vector2(spawnAreaMin.x, spawnAreaMax.y));
        Gizmos.DrawLine(new Vector2(spawnAreaMax.x, spawnAreaMin.y), new Vector2(spawnAreaMax.x, spawnAreaMax.y));
        Gizmos.DrawLine(new Vector2(spawnAreaMin.x, spawnAreaMax.y), new Vector2(spawnAreaMax.x, spawnAreaMax.y));
    }
}
