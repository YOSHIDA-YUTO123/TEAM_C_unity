using UnityEngine;
using UnityEngine.UI; // UI���g���Ƃ��ɕK�v
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timerText; // �������Ԃ�\������e�L�X�g
    [SerializeField] GameObject gameOverText; // �Q�[���I�����ɕ\������e�L�X�g
    [SerializeField] GameObject EnemyGenerat;

    public float limitTime = 10.0f; // ��������

    void Start()
    {
        // ������ԂŃQ�[���I�[�o�[�e�L�X�g���\���ɂ���
        if (gameOverText != null)
        {// null ����Ȃ�������
            gameOverText.SetActive(false);
        }
        else
        {// �f�o�b�O���O
            Debug.LogError("gameOverText ���ݒ肳��Ă��܂���B");
        }
    }

    void Update()
    {
        // ���Ԃ����炷
        limitTime -= Time.deltaTime;

        EnemyGenerat.GetComponent<EnemyGenerater24>().AddLevel = (int)(10 - limitTime / 10);

        // 0�ȉ��ɂȂ����� 0 �ɌŒ�
        if (limitTime <= 0)
        {
            limitTime = 0;

            // GameOver�̃e�L�X�g��\��
            if (gameOverText != null)
            {
                gameOverText.SetActive(true);
            }

            // �}�E�X�N���b�N�ŃQ�[���V�[�����ēǂݍ���
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("GameScene");
            }
        }

        // �c�莞�Ԃ𐮐��ŕ\��
        if (timerText != null)
        {
            timerText.text = limitTime.ToString("F0");
        }
        else
        {
            Debug.LogError("timerText ���ݒ肳��Ă��܂���B");
        }
    }
}
