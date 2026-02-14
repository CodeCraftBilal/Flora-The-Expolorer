using UnityEngine;

public class PlayControllerScript : MonoBehaviour
{
    public void OnPlay()
    {
        Debug.Log("Play is clicked");
        SceneController.instance.LoadScene("GamePlayScene");
    }
    public void OnResume()
    {
        SceneController.instance.LoadScene("GamePlayScene");
    }

    public void OnSelectLevel()
    {
        SceneController.instance.LoadScene("LevelScene");
    }

    public void OnBack()
    {
        SceneController.instance.GoBack();
    }
}
