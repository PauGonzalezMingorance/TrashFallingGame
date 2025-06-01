using UnityEngine;


public class NewMonoBehaviourScript : MonoBehaviour
{
    public enum CanColor { Red, Yellow, Blue, Green, Grey }  // add your colors here
    public CanColor trashColor;
    private float mvtSpeed = 4f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    private ScoreController score;


    void Start()
    {
        score = FindObjectOfType<ScoreController>();

        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f; // disable gravity so it's only movement-controlled
    }

    void Update()
    {
        movementDirection = new Vector2(0, -mvtSpeed);
        Debug.Log("TrashCan" + trashColor);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movementDirection;

        if (transform.position.y < -6f) // New threshold
        {
            Debug.Log("Missed or went too far — trash destroyed.");
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        string expectedCan = "trashCan" + trashColor;

        if (collision.CompareTag(expectedCan))
        {
            Destroy(gameObject);
            score.increaseScore();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
