using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // �̵� �ӵ��� �����ϴ� ����
    [SerializeField]
    private float moveSpeed = 5f;

    // Rigidbody2D ������Ʈ ����
    private Rigidbody2D rb;

    // �Է°��� ������ ����
    private Vector2 movementInput;

    void Awake()
    {
        // Rigidbody2D ������Ʈ ��������
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Ű���� �Է� �ޱ� (WASD �Ǵ� ȭ��ǥ Ű)
        // Horizontal: A/D �Ǵ� ����/������ ȭ��ǥ
        // Vertical: W/S �Ǵ� ��/�Ʒ� ȭ��ǥ
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // �Է°��� Vector2�� ����
        movementInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // �������� �̵��� FixedUpdate���� ó��
        // �Է°��� �ӵ��� ���ؼ� ���ο� ��ġ�� ���
        rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime);
    }
}