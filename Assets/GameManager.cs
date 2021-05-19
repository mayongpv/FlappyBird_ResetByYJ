using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public GameObject gameOverUI;
    public Text scoreUI;

    private void Awake()
    {
        instance = this;
    }

    internal void ShowGameOver(bool active)
{
    gameOverUI.SetActive(active);
}

}
 


