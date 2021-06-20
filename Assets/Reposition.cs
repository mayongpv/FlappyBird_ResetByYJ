using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    //배경이 -방향으로 이동한다.
    //배경이 대충 배경 길이만큼 왼쪽으로 이동했을 때,
    //배경의 길이 *2 만큼 되는 지점 (+방향)으로 이동한다. 
    //이동의 최소값(즉, 제일 많이 왼쪽으로 이동했을 때. 을 minX라고 지정했다.
    //첫번째 배경 출발 지점 x = 7, 두번째 배경 중간 정도가 25 -> 그래서 대충 -30정도를 최소값으로 정했구나. 
    public float minX = -30f;
    //만약 x가 -30보다 더 작아지면 두배 이동, 
    //+ 즉 x가 움직인 지점이  minX 값보다 작아지면 이동한다 두배 길이만큼 

    private void Update()
    {
        if (minX > transform.position.x)
        {
            transform.Translate(22.8f * 2, 0, 0);
        }
    }
}
    



