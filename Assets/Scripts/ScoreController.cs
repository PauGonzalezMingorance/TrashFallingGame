using UnityEngine;
using UnityEngine.UI; // To access the Text component

public class ScoreController : MonoBehaviour
{
    private int score;
    private Text scoreText; // Reference to the Legacy Text component

    void Start()
    {
        // Get the Text component on the same GameObject
        scoreText = GetComponent<Text>();
        UpdateScoreUI(); // Initialize the UI score display
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString(); // Update the score display
    }

    public void increaseScore()
    {
        score++;
        UpdateScoreUI(); // Update UI when score changes
    }

    public int getScore()
    {
        return this.score;
    }
}
