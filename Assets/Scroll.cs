using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float SppedX = -2;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(SppedX * Time.deltaTime,0,0);
    }
}
