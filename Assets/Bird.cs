using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    
   new public Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    float forceY = 100;
    void Update()
    {
        //���콺 Ŭ�� Ȥ�� �����̽��� �������� �۵���Ű��
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //���� �����̽� Ȥ�� ���콺 ���� �ϸ� y�� ���� �޴´�
        {
            Vector2 force;
            force.x = 0;
            force.y = forceY;
            rigidbody2D.AddForce(force); //()���� �ڸ����� vector�� ���� �ϴµ�, ���⼭ vector2�� force�� �̸� �ٿ���.
        }

    }


    //new public Rigidbody2D rigidbody2D;
    ////public Animator animator;
    //void Start()
    //{
    //    rigidbody2D = GetComponent<Rigidbody2D>();
    //    //animator = GetComponent<Animator>();
    //}

    //public float forceY = 100;
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
    //    {
    //        Vector2 force;
    //        force.x = 0;
    //        force.y = forceY;
    //        rigidbody2D.AddForce(force);

            ////���� �޷��̴� �ִϸ��̼� ����.
            //animator.Play("Flap", 0, 0);
    //    }
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    // ������.
    //    //�״� �ִϸ��̼� ����.

    //    ////���� ���� UIǥ��
    //    //GameManager.instace.SetGameOver();

    //    //// ��ũ�� �ϴ°͵� �� ���߱�
    //    //animator.Play("Die", 0, 0);
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    GameManager.instace.AddScore();
    //}
}
