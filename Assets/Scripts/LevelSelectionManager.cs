using UnityEngine;

public class LevelSelectionManager : MonoBehaviour
{
    // Call this method from an OnClick event of a UI Button for Level 1
    public void SelectLevel1()
    {
        Debug.Log("Level 1 Selected!");
        if (DataManager.instance != null)
        {
            Debug.Log("DataManager.instance is Not Null");
            // Configure Level 1 settings
            DataManager.instance.targetFruitName = "Banana"; // Ensure your Banana prefab's name contains "Banana"
            DataManager.instance.scoreToWin = 3;
            DataManager.instance.currentScore = 0;

            Debug.Log("Level 1 Selected! Target: Banana, Score needed: 3");
            
            // Assuming your game scene name is "GamePlayScene", replace if different
            SceneController.instance.LoadScene("GamePlayScene");
        }
        Debug.Log("DataManager.instance is Null");
    }

    // Example for a possible Level 2 button
    public void SelectLevel2()
    {
        if (DataManager.instance != null)
        {
            DataManager.instance.targetFruitName = "Apple"; // Example
            DataManager.instance.scoreToWin = 5;
            DataManager.instance.currentScore = 0;

            Debug.Log("Level 2 Selected! Target: Apple, Score needed: 5");
            
            SceneController.instance.LoadScene("GamePlayScene");
        }
    }
}
