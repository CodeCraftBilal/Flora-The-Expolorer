using UnityEngine;

public class DestroyOnClickScript : MonoBehaviour
{
    public ScoreScript scoreScript;
    void Start()
    {
        scoreScript = FindFirstObjectByType<ScoreScript>();
        if(gameObject == null) {
        } else
        {
            Debug.Log("gameobject is not null");
        }
    }

    public void OnMouseDown()
    {
        if (DataManager.instance != null)
        {
            string targetFruit = DataManager.instance.targetFruitName;

            if (!string.IsNullOrEmpty(targetFruit) && gameObject.tag.Contains(targetFruit))
            {
                DataManager.instance.currentScore++;
                scoreScript.PlayFruitSound(isRight: true);
                Debug.Log("Correct fruit! Score: " + DataManager.instance.currentScore);

                if (DataManager.instance.currentScore >= DataManager.instance.scoreToWin)
                {
                    scoreScript.PlayGameOverSound(isWin: true);
                    Debug.Log("You Win! You clicked " + targetFruit + " " + DataManager.instance.scoreToWin + " times.");
                }
            }
            else
            {
                scoreScript.PlayFruitSound(isRight: false);
                scoreScript.PlayGameOverSound(isWin: false);
                Debug.Log("Wrong fruit clicked! You lose the game.");
                DataManager.instance.isRightFruitClicked = false;
            }
        }
        else
        {
            Debug.LogWarning("DataManager instance not found!");
        }

        Destroy(gameObject);
    }
}
