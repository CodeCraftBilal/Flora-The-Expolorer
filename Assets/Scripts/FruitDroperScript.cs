using Unity.Mathematics;
using UnityEngine;

public class FruitDroperScript : MonoBehaviour
{
    public GameObject applePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(applePrefab, new Vector3(0f,6.10f,0f), quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
