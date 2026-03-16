using UnityEngine;
using UnityEngine.SceneManagement;

public class Learn : MonoBehaviour
{
   public void OnFruitsClick()
    {
        DataManager.instance.path = "Learn/fruits";
        SceneController.instance.LoadScene("DisplayImage");
    }
   
   public void OnFlowersClick()
    {
        DataManager.instance.path = "Learn/flowers";
        SceneController.instance.LoadScene("DisplayImage");
    }

    public void onBack()
    {
        SceneController.instance.GoBack();
    }
}
