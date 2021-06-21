using System.Collections;
using UnityEngine;

public class Column : MonoBehaviour
{

    public GameObject column;
    public float delay = 3f;
    public float randomdelay = 2f;
    public float spawnX = 4;
    public float spawnYmin = 4;
    public float spawnYmax = 4;


    IEnumerator Start()
    {
        while (true)
        {
            Vector3 pos;
            pos.z = 0;
            pos.x = spawnX;
            pos.y = Random.Range(spawnYmin, spawnYmax)  ;

            Instantiate(column, pos, column.transform.rotation);

            //3초 간격으로 배치
            yield return new WaitForSeconds(delay + Random.Range(-randomdelay, -randomdelay));

        }
    }


}
