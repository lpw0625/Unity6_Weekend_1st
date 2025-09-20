using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerJump : MonoBehaviour
{

    Rigidbody2D rigidbody2D; // 컴포넌트 부착한 물리 기능을 rigidbody2D 변수를 이용해서 사용하겠다.
    [SerializeField] float jumpPower = 5;
    [SerializeField] Vector2 dir;
    [SerializeField] LayerMask groundLayer; // 누가 땅인지 설정을 해주는것 
    [SerializeField] float grounDinstanceCheck = 2f; // 땅과의 거리체크를 위한 거리.


    // 플레이어 게임오브젝트 안에 있는 RigidBody2D 컴포넌트를 rigidbody2D안에 저장을 하고 싶다.


    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        // rigidbody2D.AddForce(new Vector2(1,1) * 5, ForceMode2D.Impulse);

        // 




    }


    //AddForce : 힘을 추가하다. 점피 =

    // Update is called once per frame
    void Update()
    {
        //rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);


        //Spacebar눌렀을 때 점프를 하고 싶다면? 

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) // 스페이스바를 누르고 땅에 밟앗을때 
        {
            rigidbody2D.AddForce(dir.normalized * jumpPower, ForceMode2D.Impulse);
            {
            }
        }

        bool IsGrounded() // 땅을 밟고 있나요?
        {
            return Physics2D.Raycast(transform.position, Vector2.down, grounDinstanceCheck, groundLayer);

        }
    }

        private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3)(Vector2.down * grounDinstanceCheck));
    }

}

              


  

