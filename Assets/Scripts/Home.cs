using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void onClickExit()
    {
        Debug.Log("Exiting");
    }

    public void OnClickLearn()
    {
        Debug.Log("Learning");
        SceneManager.LoadScene("LearnScene");
    }

    public void OnClickPlay()
    {
        Debug.Log("Playing");
        SceneManager.LoadScene("PlayScene");
    }
}
