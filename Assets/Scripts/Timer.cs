using UnityEngine;
using UnityEngine.UI; // UIを使うときに必要
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timerText; // 制限時間を表示するテキスト
    [SerializeField] GameObject gameOverText; // ゲーム終了時に表示するテキスト
    [SerializeField] GameObject EnemyGenerat;

    public float limitTime = 10.0f; // 制限時間

    void Start()
    {
        // 初期状態でゲームオーバーテキストを非表示にする
        if (gameOverText != null)
        {// null じゃなかったら
            gameOverText.SetActive(false);
        }
        else
        {// デバッグログ
            Debug.LogError("gameOverText が設定されていません。");
        }
    }

    void Update()
    {
        // 時間を減らす
        limitTime -= Time.deltaTime;

        EnemyGenerat.GetComponent<EnemyGenerater24>().AddLevel = (int)(10 - limitTime / 10);

        // 0以下になったら 0 に固定
        if (limitTime <= 0)
        {
            limitTime = 0;

            // GameOverのテキストを表示
            if (gameOverText != null)
            {
                gameOverText.SetActive(true);
            }

            // マウスクリックでゲームシーンを再読み込み
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("GameScene");
            }
        }

        // 残り時間を整数で表示
        if (timerText != null)
        {
            timerText.text = limitTime.ToString("F0");
        }
        else
        {
            Debug.LogError("timerText が設定されていません。");
        }
    }
}
