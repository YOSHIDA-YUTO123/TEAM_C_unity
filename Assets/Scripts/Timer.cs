using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIを使うときに必要

public class Timer : MonoBehaviour
{
    [SerializeField]
    Text TimerText; // テキスト名
    public float limitTime = 10; // 制限時間

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        limitTime -= Time.deltaTime;// タイム減算

        if (limitTime < 0)
        {// 0いかになった時
            limitTime = 0;// 0にする
        }

        TimerText.text = limitTime.ToString("F0"); // 残り時間を整数で表示
    }
}

