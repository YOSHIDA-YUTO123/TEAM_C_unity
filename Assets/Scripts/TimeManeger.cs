using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManeger : MonoBehaviour
{
    // �^�C�}�[����
    public int CountMin = 2;    // ��������(��)
    private float countdownSeconds; // �J�E���g�_�E��(�b)

    [SerializeField]
    Text timeText; // �e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();    // �^�C���e�L�X�g���擾
        countdownSeconds = CountMin * 60;   // ��*�b��(1����60�b�Ȃ̂�*60)
    }

    // Update is called once per frame
    void Update()
    {
        countdownSeconds -= Time.deltaTime; // �^�C�����Z
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");   // �\�����镶����

        if (countdownSeconds <= 0)
        {
            // 0�b�ɂȂ����Ƃ��̏���
            countdownSeconds = 0;
            // �N���b�N�����������x�Q�[��?or���U���g

        }
    }
}
