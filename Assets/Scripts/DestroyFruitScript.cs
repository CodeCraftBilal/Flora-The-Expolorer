using UnityEngine;

public class DestroyFruitScript : MonoBehaviour
{
    public float fallSpeed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(rb.linearVelocity.y > fallSpeed)
        {
         rb.linearVelocity = new Vector2(rb.linearVelocity.x, fallSpeed);   
        // rb.linearVelocity = Vector2.down * fallSpeed;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
