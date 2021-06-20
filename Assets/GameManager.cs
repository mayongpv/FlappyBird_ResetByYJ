using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public GameObject gameOverUI;
    public Text scoreUI;

    private void Awake()
    {
        instance = this;
        gameOverUI.SetActive(false);
    }
    bool isGameOver; //평소에 아무것도 지정안하면 기본 값이 false : 원래 bool 형식의 기본값이 false
    internal void SetGameOver()
    { //셋게임오버하면
        isGameOver = true; //트루로 바뀌고
        ShowGameOver(true); //이것도 트루로 바뀐다.->게임오버 UI 보여주는 함수
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //만약 스페이스 혹은 마우스 왼쪽 하면 y가 힘을 받는다
            {
                //게임 재시작
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
        internal void ShowGameOver(bool active)
    {
        gameOverUI.SetActive(active);
    }
    int score;

    internal void AddScore()
    {
        score += 100;
        scoreUI.text = "Score :" + score;

    }
    
    }




