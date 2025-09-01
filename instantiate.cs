using UnityEngine;

public class instantiate : MonoBehaviour
{

    public GameObject[] bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Invoke("RandomBall", 5f);
        InvokeRepeating("RandomBall", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void RandomBall()
    {
        int x = Random.Range(0, bullet.Length);
        Instantiate(bullet[x], transform.position, Quaternion.identity);
    }
}
