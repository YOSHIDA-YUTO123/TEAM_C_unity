using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManeger : MonoBehaviour
{
    // タイマー処理
    public int CountMin = 2;    // 制限時間(分)
    private float countdownSeconds; // カウントダウン(秒)

    [SerializeField]
    Text timeText; // テキスト

    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();    // タイムテキストを取得
        countdownSeconds = CountMin * 60;   // 分*秒数(1分は60秒なので*60)
    }

    // Update is called once per frame
    void Update()
    {
        countdownSeconds -= Time.deltaTime; // タイム減算
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");   // 表示する文字列

        if (countdownSeconds <= 0)
        {
            // 0秒になったときの処理
            countdownSeconds = 0;
            // クリックしたらもう一度ゲーム?orリザルト

        }
    }
}
