using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public GameObject gameOverUI;
    public float scrollSpeedXMultiply = 1;

    public Text scoreUI;
    Text highScoreText;
    int highScore; //최고점수 저장. 게임시작되면 초기화, 게임중 점수 넘기면 UI와 함께 갱신
    int HighScore;
//    {
//        set
//        {
//highScore = value;
//        if(highScoreText == null)
//        highScoreText = GameObject.Find("Canvas").transform.Find("HighScore").GetComponent<Text>();

//        highScoreText.text = $"high Score : {highScore.ToNumber()};
//        playerPrefabs.SetInt("HighScore", highScore);
//        PlayerPrefs.Save();
//        }
//}
//    private void Awake()
//{
//    instance = this;
//    ShowGameOver(false);
//    int highScore = PlayerPrefs.GetInt("HighScore");
//    HighScore = highScore; //속성
//}

//void SetHighScore(int_highScore)
//{
//    highScore = _highScore;
//    highScoreText.text = $"High Score : {highScore.ToNumber()}";
//        PlayerPrefabs.SetInt("HighScore", highScore);
//    PlayerPrefs.Save();
//}
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

//if (score > highScore)
//{
//    SetHighScore = score;
}






