using UnityEngine;
using UnityEngine.UI;

public class DisplayImage : MonoBehaviour
{
    public Image imageViewer;
    public void OnClickNext()
    {
        Debug.Log("Next is Clicked");
    }
    
    public void OnClickPrevious()
    {
        Debug.Log("Previous is Clicked");   
    }
}
