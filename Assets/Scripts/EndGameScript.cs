using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
    public HealthController health;
    public GameObject EndPanel;

    public void RestartGameEasy()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(1);
    }

    public void RestartGameMedium()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(2);
    }
    public void RestartGameHard()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(3);
    }
}
