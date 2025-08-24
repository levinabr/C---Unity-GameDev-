using UnityEngine;

public class MouseTracker : MonoBehaviour
{
    private Vector3 previousMousePosition;
    private bool isTracking;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousMousePosition = Input.mousePosition;
            isTracking = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isTracking = false;
        }

        if (isTracking)
        {
            Vector3 currentMousePosition = Input.mousePosition;
            Vector3 delta = currentMousePosition - previousMousePosition;
            
            Debug.Log("Mouse Delta: " + delta);
            
            previousMousePosition = currentMousePosition;
        }
    }
}
