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
        SceneManager.LoadScene("LearnScene");
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
