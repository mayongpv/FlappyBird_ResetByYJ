using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CodephyBird : Bird //버드를 상속받음! -> Bird 스크립트에 있는 내용이 다 작동한다. 
                                //하지만 Start랑 Update 는 부모에 있는게 아니라 자기 자신한테 있는게 호출된다. 
{
    private void Start()
    {
        base.Start();

        //인스펙터에서 물리 키네마틱으로 만들어주는 코드. 
        //따로 설정 눌렀으면 코드 안써줘도 된다. 
        rigidbody2D.bodyType = RigidbodyType2D.Kinematic;
        rigidbody2D.useFullKinematicContacts = true;

    }
    public float gravity = 9.8f;
    public float acceleration;

    private void Update()
    {
        acceleration += gravity * Time.deltaTime;

        //y값 변경
        transform.Translate(0, acceleration, 0);

        //터치했을 새에 날아오르는 힘 주기
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //만약 스페이스 혹은 마우스 왼쪽 하면 y가 힘을 받는다
        {
            if (Time.time > 0.7f)
            {
                acceleration = forceY;
                //날개 펄럭이는 애니메이션 하자
                animator.Play("Flap", 0, 0); //1이면 애니메이션 끝
            }
        }
    }
}

