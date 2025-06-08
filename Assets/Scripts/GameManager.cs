using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public string difficulty = "Easy"; // Default difficulty

    void Awake()
    {
        // Singleton pattern to ensure only one GameManager instance exists
        if (Instance ==  null)
        {
            Instance = this;
            DontDestroyOnLoad(this); // Prevent destruction when switching scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
