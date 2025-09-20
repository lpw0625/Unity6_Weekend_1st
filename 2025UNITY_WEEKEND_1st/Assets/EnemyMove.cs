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

    private void OnCollisionEnter2D(Collision2D collision) // 충돌했을 때 이 코드를 실행하세요
    {
        // 충돌한 대상이 Player인가요?
        if (collision.collider.CompareTag("Player")) // 충돌했을 때 플레이어이면 다음과 같은 조건을 실행하겠다.
        {
            Debug.Log("플레이어가 충돌하여 게임이 종료됩니다."); // 충돌했을때 나오는 조건 

            // 실제로 게임오버가 되었을 떄 무슨 일이 발생할까?
            // UI  게임오버 창이 떠서 버튼을 클릭하면 재시작을 할 수 있게한다.
            // rigidbody2d와 점프 관련 변수를 만들어 점프하도록 만들어보세요
        }
        // 

    }

  
        
  }



