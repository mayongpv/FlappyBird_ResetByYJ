using System.Collections;
using UnityEngine;

public class Column : MonoBehaviour
{
    //���� ���۵Ǹ�
    //�������� �����ϱ� - ���� �Լ� �ʿ�
    //Y ���� ���� �־����. 
    //x ���� ������?


    //// 3�� �������� ��ġ : �ڸ�ƾ �Լ� ����ϱ�

    public GameObject column;
    public float delay = 3f;
    public float randomdelay = 2f;
    public float spawnX = 4;
    public float spawnYmin = 4;
    public float spawnYmax = 4;

//�;ƾƾƾƤ� ���� �𸣰ڴ°�???? ^^

    IEnumerator Start()
    {
        while (true)
        {
            Vector3 pos;
            pos.x = spawnX;
            pos.y = Random.Range(spawnYmin, spawnYmax)  ;
            pos.z = 0;


            Instantiate(column, pos, column.transform.rotation);

            //3�� �������� ��ġ
            yield return new WaitForSeconds(delay + Random.Range(-randomdelay, -randomdelay));

        }
    }


}
