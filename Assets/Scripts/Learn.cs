using UnityEngine;
using UnityEngine.SceneManagement;

public class Learn : MonoBehaviour
{
   public void OnFruitsClick()
    {
        SceneManager.LoadScene("DisplayImage");
    }
   
   public void OnFlowersClick()
    {
        SceneManager.LoadScene("DisplayImage");
    }
}
