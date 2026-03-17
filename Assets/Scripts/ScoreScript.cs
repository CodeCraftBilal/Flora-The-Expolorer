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
    public AudioSource audioSource;
    public AudioSource loseAudioSource;
    public AudioSource winAudioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DataManager.instance.isRightFruitClicked = true;
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
            ActiveGameOverPannel("You Win");
        }
        if (!DataManager.instance.isRightFruitClicked)
        {
            ActiveGameOverPannel("You Lose");
        }
    }

    public void PlayFruitSound(bool isRight)
    {
        if(isRight) audioSource.Play();
        else audioSource.Play();
    }

    public void PlayGameOverSound(bool isWin)
    {
        if(isWin) winAudioSource.Play();
        else loseAudioSource.Play();
    }

    private void ActiveGameOverPannel(String textToShow)
    {
        GameOverPannel.SetActive(true);
        afterGameScoreText.text = textToShow;
        inGameScoreText.enabled = false;
        DataManager.instance.currentScore = 0;
        Time.timeScale = 0;
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
