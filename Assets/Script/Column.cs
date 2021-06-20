using System.Collections;
using UnityEngine;

public class Column : MonoBehaviour
{
    //씬이 시작되면
    //랜덤으로 생성하기 - 랜덤 함수 필요
    //Y 값의 범위 있어야함. 
    //x 값은 고정값?


    //// 3초 간격으로 배치 : 코르틴 함수 사용하기

    public GameObject column;
    public float delay = 3f;
    public float randomdelay = 2f;
    public float spawnX = 4;
    public float spawnYmin = 4;
    public float spawnYmax = 4;

//와아아아아ㅏ 전혀 모르겠는걸???? ^^

    IEnumerator Start()
    {
        while (true)
        {
            Vector3 pos;
            pos.x = spawnX;
            pos.y = Random.Range(spawnYmin, spawnYmax)  ;
            pos.z = 0;


            Instantiate(column, pos, column.transform.rotation);

            //3초 간격으로 배치
            yield return new WaitForSeconds(delay + Random.Range(-randomdelay, -randomdelay));

        }
    }


}
