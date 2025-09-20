using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rigidbody2;
    [SerializeField] Vector2 moveDir;
    [SerializeField] float moveSpeed;
    [SerializeField] float enemyJumpPower = 5; 

    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();

        rigidbody2.linearVelocity = moveDir.normalized * moveSpeed;

        rigidbody2.AddForce(new Vector2(1, 1) * 5, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision) // �浹���� �� �� �ڵ带 �����ϼ���
    {
        // �浹�� ����� Player�ΰ���?
        if (collision.collider.CompareTag("Player")) // �浹���� �� �÷��̾��̸� ������ ���� ������ �����ϰڴ�.
        {
            Debug.Log("�÷��̾ �浹�Ͽ� ������ ����˴ϴ�."); // �浹������ ������ ���� 

            // ������ ���ӿ����� �Ǿ��� �� ���� ���� �߻��ұ�?
            // UI  ���ӿ��� â�� ���� ��ư�� Ŭ���ϸ� ������� �� �� �ְ��Ѵ�.
            // rigidbody2d�� ���� ���� ������ ����� �����ϵ��� ��������
        }
        // 

    }

  
        
  }



