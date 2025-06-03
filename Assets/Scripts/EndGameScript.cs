using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
    public HealthController health;
    public GameObject EndPanel;

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(1);
        
    }
}
