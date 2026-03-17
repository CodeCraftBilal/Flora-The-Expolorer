using UnityEngine;

public class DestroyOnClickScript : MonoBehaviour
{
    public ScoreScript scoreScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreScript = FindFirstObjectByType<ScoreScript>();
        if(gameObject == null) {
            // Debug.Log("game object is null");
        } else
        {
            // Debug.Log("gameobject is not null");
        }
    }

    public void OnMouseDown()
    {
        // Debug.Log("Fruit Clicked: " + gameObject.name);

        if (DataManager.instance != null)
        {
            string targetFruit = DataManager.instance.targetFruitName;

            // Instantiated objects often get "(Clone)" added to their name
            // So we use Contains to match the target fruit
            if (!string.IsNullOrEmpty(targetFruit) && gameObject.tag.Contains(targetFruit))
            {
                DataManager.instance.currentScore++;
                scoreScript.PlayFruitSound(isRight: true);
                Debug.Log("Correct fruit! Score: " + DataManager.instance.currentScore);

                if (DataManager.instance.currentScore >= DataManager.instance.scoreToWin)
                {
                    Debug.Log("You Win! You clicked " + targetFruit + " " + DataManager.instance.scoreToWin + " times.");
                    // You can call SceneController.instance.LoadScene("WinScene"); or show a Win Panel here
                }
            }
            else
            {
                scoreScript.PlayFruitSound(isRight: false);
                Debug.Log("Wrong fruit clicked! You lose the game.");
                DataManager.instance.isRightFruitClicked = false;
                // You can call SceneController.instance.LoadScene("LoseScene"); or show a Lose Panel here
            }
        }
        else
        {
            Debug.LogWarning("DataManager instance not found!");
        }

        Destroy(gameObject);
    }
}
