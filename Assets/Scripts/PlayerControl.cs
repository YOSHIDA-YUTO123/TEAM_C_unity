using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    private int BulletPattern = 2;
    public int HP = 100;
    public int ATK = 10;
    public int BulletMode = 0;
    public float MovePow = 0.1f;
    public float LimitX = 8.5f;
    public float LimitY = 4.5f;
    public float shotAngle = 15f; // �e���J���p�x
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    Rigidbody2D rigid2D;
    public int nDamage = 100;

    public SceneSelectEX sceneSelector;

    // **�Q�[���i�s�t���O**
    private bool isGameOver = false; // �v���C���[�����S�����true�ɂȂ�

    // Start is called before the first frame update
    void Start()
    {

        Application.targetFrameRate = 150;
    }

    // Update is called once per frame
    void Update()
    {

        // **�v���C���[�����S���Ă���ꍇ�A�X�V�������~**
        if (isGameOver) return;

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -MovePow;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * MovePow;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * MovePow;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.up * -MovePow;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(BulletMode % BulletPattern == 0)
            {
                GameObject Bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                Bullet.GetComponent<BulletControl1>().Damege = GetBulletATK();
            }
            else if (BulletMode % BulletPattern == 1)
            {
                GameObject Bullet = Instantiate(bulletPrefab2, transform.position, transform.rotation * Quaternion.Euler(0, 0, shotAngle));
                Bullet.GetComponent<BulletControl2>().Damege = GetBulletATK() / 2;

                GameObject Bullet2 = Instantiate(bulletPrefab2, transform.position, transform.rotation * Quaternion.Euler(0, 0, -shotAngle));
                Bullet2.GetComponent<BulletControl2>().Damege = GetBulletATK() / 2;

                GameObject Bullet3 = Instantiate(bulletPrefab2, transform.position, Quaternion.identity);
                Bullet3.GetComponent<BulletControl2>().Damege = GetBulletATK() / 2;
            }
        }

        transform.position = new Vector2(
              //�G���A�w�肵�Ĉړ�����
              Mathf.Clamp(transform.position.x, -LimitX, LimitX),
              Mathf.Clamp(transform.position.y, -LimitY, LimitY)
              );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // �G�Ƃ̏Փ�
        if (other.gameObject.CompareTag("Enemy"))
        {
            // �̗͂����炷
            HP -= nDamage;

            if (HP <= 0)
            {// �̗͂�0�ȉ�
                // �v���C���[�Ȃ��Ȃ�
                gameObject.SetActive(false);

                // **�Q�[���I�[�o�[�t���O�𗧂Ă�**
                isGameOver = true;

                // ���S����
                sceneSelector.OnPlayerDeath();

                if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Return))
                {// �Q�[���V�[����ǂݍ���
                    SceneManager.LoadScene("GameScene");
                }


            }

        }
    }

    public int GetBulletATK()
    {
        return ATK;
    }
}
