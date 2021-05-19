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

   public float ForceY = 100;
    void Update()
    {
        //���콺 Ŭ�� Ȥ�� �����̽��� �������� �۵���Ű��
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //���� �����̽� Ȥ�� ���콺 ���� �ϸ� y�� ���� �޴´�
        {
            Vector2 force;
            force.x = 0;
            force.y = ForceY;
            rigidbody2D.AddForce(force); //()���� �ڸ����� vector�� ���� �ϴµ�, ���⼭ vector2�� force�� �̸� �ٿ���.
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //���浹�� ����
        GameManager.instance.ShowGameOver(false);
    }


    //    //animator = GetComponent<Animator>();
    //}


    ////���� �޷��̴� �ִϸ��̼� ����.
    //animator.Play("Flap", 0, 0);
    //    }
    //}



    //    //// ��ũ�� �ϴ°͵� �� ���߱�
    //    //animator.Play("Die", 0, 0);
    //}

}
