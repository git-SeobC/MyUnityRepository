using System;
using UnityEngine;
// �÷��̾��� �̵�(������ٵ�) -> ������ ���� �̵�, Transform������ �̵� X

// �ش� ����� ���� �� ��ũ��Ʈ�� ������Ʈ�ν� ����� ���
// ������� ������Ʈ�� �䱸�ϰ� �˴ϴ�.
// 1. �ش� ������Ʈ�� ���� ������Ʈ�� ������ ��� �ڵ����� ������ ����
// 2. �� ��ũ��Ʈ�� ����� ���¶�� �� ������Ʈ�� ����� ������Ʈ�� ������ �� ����
[RequireComponent(typeof(Rigidbody2D))] // �ʼ� ������Ʈ�� ��� ���� ������ ����, ���� ������Ʈ�� ��ũ��Ʈ �߰��� �ش� ������Ʈ �ڵ����� �߰�
public class PlayerMovement : MonoBehaviour
{
    //public int a = 10;
    public float speed = 10.0f; // �Ҽ����� ���� ���� �������� 'f'�� ���
    // �Ҽ��� �� 6�ڸ����� ��Ȯ�ϰ� ���
    public double jump_force = 3.5; // double�� �Ǽ��� ǥ���ϴ� �ڷ���, 'f'�� ������ ����
    // �Ҽ��� �� 15�ڸ����� ��Ȯ�ϰ� ���

    public bool isjump = false;

    private Rigidbody2D rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        // GetComponent<T> => �ش� ������Ʈ�� ���� ������ ���
        // T �κп��� ������Ʈ�� ���¸� �ۼ����ݴϴ�. ������Ʈ�� ���°� �ٸ��ٸ� ���� �߻�
        // �ش� �����Ͱ� �������� ���� ����� null�� ��ȯ�ϰ� �˴ϴ�.
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        // GetAxisRaw("Ű ��"); �� ��ǲ �Ŵ����� Ű�� �����鼭
        // Ŭ���� ���� -1, 0 , 1�� ��ġ�� ���� ���ɴϴ�.

        // Horizontal : ���� �̵� a, d Ű�� Ű������ ����, ������ Ű
        // Vertical : ���� �̵� w, s Ű�� Ű������ ��, �Ʒ� Ű

        // ���� �ڵ带 ���� ������ ������ ����մϴ�.
        Vector3 velocity = new Vector3(x, y, 0) * speed * Time.deltaTime;
        // �ӷ� = ���� * �ӵ�

        transform.position += velocity;

    }

    private void Jump()
    {
        // ����ڰ� Ű���� Space Ű�� �Է��Ѵٸ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isjump) // ���� ���°� �ƴ� ���
            {
                isjump = true; // ���� ���·� ����
                rigid.AddForce(Vector3.up * (float)jump_force, ForceMode2D.Impulse); // ����Ƽ �ڵ� ��κ� float�̱� ������ double�� �� �Ⱦ�
                // type casting
                // "(Ÿ�� �̸�)����" �� ���� �ش� ������ ������ Ÿ������ ������ �� �ֽ��ϴ�.
                // �� ĳ������ ������ ���������� ������ �� �ֽ��ϴ�.
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹ü�� ���� ������Ʈ�� ���̾ 7�� ������ �� ũ�Ⱑ ���ٸ�
        //if (collision.gameObject.layer == 7)
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Ground")
        {
            isjump = false;
        }
        Debug.Log("���� ��ҽ��ϴ�!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("����!!");
        }
    }
}
