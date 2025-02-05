using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectEX : MonoBehaviour
{
    // �v���C���[�̐������Ǘ�����t���O
    private bool isPlayerDead = false;

    // Start is called before the first frame update
    void Start()
    {
        // �Q�[���J�n���̓v���C���[���������Ă���
        isPlayerDead = false;
    }

    void Update()
    {
        // �v���C���[�����S���Ă���ꍇ�̂݁A�N���b�N�܂���Enter�L�[�ŃV�[�����ēǂݍ���
        if (isPlayerDead && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return)))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    // �v���C���[���S���ɌĂяo���֐�
    public void OnPlayerDeath()
    {
        isPlayerDead = true;
    }
}
