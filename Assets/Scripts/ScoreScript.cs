using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int score;
    private int gameOverScore;
    public GameObject GameOverPannel;
    public Text inGameScoreText;
    public Text afterGameScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameOverPannel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score = DataManager.instance.currentScore;
        gameOverScore = score;
        inGameScoreText.text = DataManager.instance.targetFruitName + " : " + score;
        if(score == DataManager.instance.scoreToWin)
        {
            GameOverPannel.SetActive(true);
            afterGameScoreText.text = "You Win";
            inGameScoreText.enabled = false;
            Time.timeScale = 0;
        }
    }

    public void SelectLevel()
    {
        SceneController.instance.LoadScene("LevelScene");
    }

    public void Restart()
    {
        SceneController.instance.LoadScene("GamePlayScene");
    }

    public void Home()
    {
        SceneController.instance.LoadScene("HomeScene");
    }
}
