using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 이동 속도를 조절하는 변수
    [SerializeField]
    private float moveSpeed = 5f;

    // Rigidbody2D 컴포넌트 참조
    private Rigidbody2D rb;

    // 입력값을 저장할 변수
    private Vector2 movementInput;

    void Awake()
    {
        // Rigidbody2D 컴포넌트 가져오기
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 키보드 입력 받기 (WASD 또는 화살표 키)
        // Horizontal: A/D 또는 왼쪽/오른쪽 화살표
        // Vertical: W/S 또는 위/아래 화살표
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // 입력값을 Vector2에 저장
        movementInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // 물리적인 이동은 FixedUpdate에서 처리
        // 입력값과 속도를 곱해서 새로운 위치를 계산
        rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime);
    }
}