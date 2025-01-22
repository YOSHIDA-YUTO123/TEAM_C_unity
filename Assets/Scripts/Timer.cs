using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI���g���Ƃ��ɕK�v

public class Timer : MonoBehaviour
{
    [SerializeField]
    Text TimerText; // �e�L�X�g��
    public float limitTime = 10; // ��������

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        limitTime -= Time.deltaTime;// �^�C�����Z

        if (limitTime < 0)
        {// 0�����ɂȂ�����
            limitTime = 0;// 0�ɂ���
        }

        TimerText.text = limitTime.ToString("F0"); // �c�莞�Ԃ𐮐��ŕ\��
    }
}

