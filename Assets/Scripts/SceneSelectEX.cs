using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectEX : MonoBehaviour
{
    // プレイヤーの生死を管理するフラグ
    private bool isPlayerDead = false;

    // Start is called before the first frame update
    void Start()
    {
        // ゲーム開始時はプレイヤーが生存している
        isPlayerDead = false;
    }

    void Update()
    {
        // プレイヤーが死亡している場合のみ、クリックまたはEnterキーでシーンを再読み込み
        if (isPlayerDead && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return)))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    // プレイヤー死亡時に呼び出す関数
    public void OnPlayerDeath()
    {
        isPlayerDead = true;
    }
}
