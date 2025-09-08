using UnityEngine;

public class RunnerMove : MonoBehaviour
{
    public Transform player;
    public float baseSpeed = 5f;
    
    private SpriteRenderer spriteRenderer;
    private float previousPlayerX;
    
    void Start()
    {
        previousPlayerX = player.position.x;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float playerMovement = player.position.x - previousPlayerX;

        if (playerMovement > 0f)
        {
            transform.Translate(Vector2.right * baseSpeed * Time.deltaTime);
        }
        
        float distance = transform.position.x - player.position.x;
        if (distance <= 1f)
        {
            spriteRenderer.color = Color.red;
        }
        
        previousPlayerX = player.position.x;
    }
}
