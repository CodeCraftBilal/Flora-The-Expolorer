using System;
using UnityEngine;

public class PlayControllerScript : MonoBehaviour
{
    private void LoadLevel(int levelNum, string fruitName, int scoreToWin)
    {
        Debug.Log($"Level {levelNum} Selected!");
        if (DataManager.instance != null)
        {
            Debug.Log("DataManager.instance is Not Null");
            // Configure level settings
            DataManager.instance.targetFruitName = fruitName;
            DataManager.instance.scoreToWin = scoreToWin;
            DataManager.instance.currentScore = 0;

            PlayerPrefs.SetInt("CurrentLevel", levelNum);
            PlayerPrefs.SetString("fruitName", fruitName);
            PlayerPrefs.SetInt("scoreToWin", scoreToWin);

            Debug.Log($"Level {levelNum} Selected! Target: {fruitName}, Score needed: {scoreToWin}");
            
            // Assuming your game scene name is "GamePlayScene", replace if different
            SceneController.instance.LoadScene("GamePlayScene");
        }
        else
        {
            Debug.Log("DataManager.instance is Null");
        }
    }

    public void OnPlay()
    {
        Debug.Log("Play is clicked");
        SceneController.instance.LoadScene("GamePlayScene");
    }
    public void OnResume()
    {
        int levelNum = PlayerPrefs.GetInt("CurrentLevel");
        string fruitName = PlayerPrefs.GetString("fruitName");
        int scoreToWin = PlayerPrefs.GetInt("scoreToWin");
        LoadLevel(levelNum, fruitName, scoreToWin);
        // SceneController.instance.LoadScene("GamePlayScene");
    }

    public void OnSelectLevel()
    {
        SceneController.instance.LoadScene("LevelScene");
    }

    public void OnBack()
    {
        SceneController.instance.GoBack();
    }
    public void OnClickHome()
    {
        SceneController.instance.GoHome();
    }
}
