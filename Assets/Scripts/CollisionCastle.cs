using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCastle : MonoBehaviour
{
    // ��ƓG�̓����蔻��
    public int CastleLife = 100; // ��̗�
    public int nDamege = 2;      // �_���[�W��

    public GameObject effectPrefab;// �G�t�F�N�g�v���n�u�p

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
        // �G�Ƃ̏Փ�
        if (other.gameObject.CompareTag("Enemy"))
        {
            // �̗͂����炷
            CastleLife -= nDamege;

            // ����������
            Destroy(other.gameObject);

            if (CastleLife > 0)
            {// �̗͂�0�ȏ�
                // �G�t�F�N�g
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);

                // �G�t�F�N�g��4�b��ɉ�ʂ������
                Destroy(effect, 4.0f);
            }

            if (CastleLife <= 0)
            {// �̗͂�0�ȉ�
                // ��Ȃ��Ȃ�
                gameObject.SetActive(false);
            }

        }
    }

}

