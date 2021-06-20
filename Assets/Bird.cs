﻿using System;
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
        //마우스 클릭 혹은 스페이스바 눌렀을때 작동시키기
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //만약 스페이스 혹은 마우스 왼쪽 하면 y가 힘을 받는다
        {
            Vector2 force;
            force.x = 0;
            force.y = ForceY;
            rigidbody2D.AddForce(force); //()안의 자리에는 vector가 들어가야 하는데, 여기서 vector2를 force로 이름 붙였다.
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //새충돌시 죽음
        GameManager.instance.SetGameOver();
    }

    private void OnTiggerEnter2D(Collider2D collider2D)
    {
        GameManager.instance.AddScore();
    }


    //    //animator = GetComponent<Animator>();
    //}


    ////날개 펄럭이는 애니메이션 하자.
    //animator.Play("Flap", 0, 0);
    //    }
    //}



    //    //// 스크롤 하는것들 다 멈추기
    //    //animator.Play("Die", 0, 0);
    //}

}
