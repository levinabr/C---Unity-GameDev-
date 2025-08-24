using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Horizontal movement input
        float moveInput = Input.GetAxisRaw("Horizontal");
        
        // Apply movement velocity
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        
        // Flip character based on movement direction
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
