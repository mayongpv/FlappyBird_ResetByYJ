using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    //����� -�������� �̵��Ѵ�.
    //����� ���� ��� ���̸�ŭ �������� �̵����� ��,
    //����� ���� *2 ��ŭ �Ǵ� ���� (+����)���� �̵��Ѵ�. 
    //�̵��� �ּҰ�(��, ���� ���� �������� �̵����� ��. �� minX��� �����ߴ�.
    //ù��° ��� ��� ���� x = 7, �ι�° ��� �߰� ������ 25 -> �׷��� ���� -30������ �ּҰ����� ���߱���. 
    public float minX = -30f;
    //���� x�� -30���� �� �۾����� �ι� �̵�, 
    //+ �� x�� ������ ������  minX ������ �۾����� �̵��Ѵ� �ι� ���̸�ŭ

    private void Update()
    {
        if (minX > transform.position.x)
        {
            transform.Translate(22.8f * 2, 0, 0);
        }
    }
}
    



