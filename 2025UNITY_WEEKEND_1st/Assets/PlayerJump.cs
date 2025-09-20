using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerJump : MonoBehaviour
{

    Rigidbody2D rigidbody2D; // ������Ʈ ������ ���� ����� rigidbody2D ������ �̿��ؼ� ����ϰڴ�.
    [SerializeField] float jumpPower = 5;
    [SerializeField] Vector2 dir;
    [SerializeField] LayerMask groundLayer; // ���� ������ ������ ���ִ°� 
    [SerializeField] float grounDinstanceCheck = 2f; // ������ �Ÿ�üũ�� ���� �Ÿ�.


    // �÷��̾� ���ӿ�����Ʈ �ȿ� �ִ� RigidBody2D ������Ʈ�� rigidbody2D�ȿ� ������ �ϰ� �ʹ�.


    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        // rigidbody2D.AddForce(new Vector2(1,1) * 5, ForceMode2D.Impulse);

        // 




    }


    //AddForce : ���� �߰��ϴ�. ���� =

    // Update is called once per frame
    void Update()
    {
        //rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);


        //Spacebar������ �� ������ �ϰ� �ʹٸ�? 

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) // �����̽��ٸ� ������ ���� ������� 
        {
            rigidbody2D.AddForce(dir.normalized * jumpPower, ForceMode2D.Impulse);
            {
            }
        }

        bool IsGrounded() // ���� ��� �ֳ���?
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

              


  

