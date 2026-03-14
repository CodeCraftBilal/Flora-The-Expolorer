using UnityEngine;

public class DestroyOnClickScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(gameObject == null) {
            Debug.Log("game object is null");
        } else
        {
            Debug.Log("gameobject is not null");
        }
    }

    public void OnMouseDown()
    {
        Debug.Log("Fruit Clicked");
        Destroy(gameObject);
    }

    
}
