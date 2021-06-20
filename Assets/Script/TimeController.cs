using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{


    int score;
    internal void AddScore()
    {
        score += 100;
        //scoreUI.text = "Score :" + score;
    }

}
