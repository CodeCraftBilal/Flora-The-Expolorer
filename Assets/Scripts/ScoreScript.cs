using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int score;
    private int gameOverScore;
    public GameObject GameOverPannel;
    public Text inGameScoreText;
    public Text afterGameScoreText;
    public Text TargetFruitText;
    public GameObject targetPannel;
    public float targetDisplayTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        Debug.Log("timescale: " + Time.timeScale);
        TargetTextShow();
        GameOverPannel.SetActive(false);
        StartCoroutine(HideTargetText());
    }

    private void TargetTextShow()
    {
        TargetFruitText.text = "Eat " + DataManager.instance.scoreToWin + DataManager.instance.targetFruitName;
    }

    // Update is called once per frame
    void Update()
    {
        score = DataManager.instance.currentScore;
        gameOverScore = score;
        inGameScoreText.text = DataManager.instance.targetFruitName + " : " + score;
        if (score == DataManager.instance.scoreToWin)
        {
            GameOverPannel.SetActive(true);
            afterGameScoreText.text = "You Win";
            inGameScoreText.enabled = false;
            DataManager.instance.currentScore = 0;
            Time.timeScale = 0;
        }
    }

    IEnumerator HideTargetText()
    {
        yield return new WaitForSeconds(targetDisplayTime);
        targetPannel.SetActive(false);
    }

    public void SelectLevel()
    {
        Time.timeScale = 1;
        SceneController.instance.PopScene(2);
        SceneController.instance.LoadScene("LevelScene");
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneController.instance.PopScene(1);
        SceneController.instance.LoadScene("GamePlayScene");
    }

    public void Home()
    {
        Time.timeScale = 1;
        SceneController.instance.PopAll();
        SceneController.instance.LoadScene("HomeScene");
    }
}
