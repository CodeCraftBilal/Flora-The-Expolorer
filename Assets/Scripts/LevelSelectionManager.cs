using UnityEngine;

public class LevelSelectionManager : MonoBehaviour
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

            Debug.Log($"Level {levelNum} Selected! Target: {fruitName}, Score needed: {scoreToWin}");
            
            // Assuming your game scene name is "GamePlayScene", replace if different
            SceneController.instance.LoadScene("GamePlayScene");
        }
        else
        {
            Debug.Log("DataManager.instance is Null");
        }
    }

    // Call these methods from OnClick events of UI Buttons for each Level
    public void SelectLevel1()  { LoadLevel(1, "Banana", 3); }
    public void SelectLevel2()  { LoadLevel(2, "Apple", 5); }
    public void SelectLevel3()  { LoadLevel(3, "Avocado", 8); }
    public void SelectLevel4()  { LoadLevel(4, "Chery", 10); }
    public void SelectLevel5()  { LoadLevel(5, "Lemon", 12); }
    public void SelectLevel6()  { LoadLevel(6, "Strawbery", 15); }
    public void SelectLevel7()  { LoadLevel(7, "Water Mellon", 20); }
    public void SelectLevel8()  { LoadLevel(8, "Banana", 25); }
    public void SelectLevel9()  { LoadLevel(9, "Apple", 30); }
    public void SelectLevel10() { LoadLevel(10, "Avocado", 35); }
}
