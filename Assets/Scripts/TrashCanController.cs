using UnityEngine;

public class TrashCanGroupController : MonoBehaviour
{
    private float fixedY;
    private Vector3 lastMousePosition;

    void Start()
    {
        fixedY = transform.position.y;
        lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void Update()
    {
        if(!GamePlayManager.isGamePaused)
        {
            if (Input.GetMouseButton(0)) // Left mouse button held down
            {
                Vector3 currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                float deltaX = currentMousePos.x - lastMousePosition.x; // How much mouse moved horizontally

                transform.position += new Vector3(deltaX, 0f, 0f); // Move group by deltaX on X axis

                lastMousePosition = currentMousePos; // Update last mouse position
            }
            else
            {
                // When not dragging, reset lastMousePosition so next drag doesn't jump
                lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }
}
