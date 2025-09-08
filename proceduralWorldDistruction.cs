using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    private Transform destroyPoint; // No need to assign in Inspector now

    void Start()
    {
        GameObject destroyPointObject = GameObject.Find("DestroyPoint");
        
        if (destroyPointObject != null)
        {
            destroyPoint = destroyPointObject.transform;
        }
        else
        {
            Debug.LogError("Could not find an object named 'DestroyPoint'! Platforms will not be destroyed.");
        }
    }

    void Update()
    {
        if (destroyPoint == null)
            return; 

        float platformRightEdge = transform.position.x + 
            (GetComponent<BoxCollider2D>().size.x * transform.localScale.x / 2);

        if (platformRightEdge < destroyPoint.position.x)
        {
            Destroy(gameObject);
        }
    }
}
