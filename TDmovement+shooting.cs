using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public GameObject BulletPrefab;
    public Transform firePoint;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    void HandleMovement()
    {

        float xinput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(xinput * speed, yInput * speed);
        if (xinput > 0)
        {
            transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        }
        else if (xinput < 0)
        {
            transform.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
        }

    }
    void Shoot()
    { 
         Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; 
        Vector2 shootDirection = (mousePos - firePoint.position).normalized;

        
        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
        Quaternion bulletRotation = Quaternion.Euler(0, 0, angle - 90); 

        
        Instantiate(BulletPrefab, firePoint.position, bulletRotation);
    }
    
     
}
