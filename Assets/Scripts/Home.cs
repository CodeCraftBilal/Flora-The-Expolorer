using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void onClickExit()
    {
        Debug.Log("Exiting");
        Application.Quit();
    }

    public void OnClickLearn()
    {
        SceneController.instance.LoadScene("LearnScene");
    }

    public void OnClickPlay()
    {
        SceneController.instance.LoadScene("PlayScene");
    }
}
