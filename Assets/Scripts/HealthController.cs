using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int noOfLives = 3;
    public GameObject heartPrefab;
    public Transform heartsParent;
    public GameObject endPanel;

    private List<GameObject> hearts = new List<GameObject>();

    void Start()
    {

        if (endPanel != null)
        {
            endPanel.SetActive(false);
        }

        for (int i = 0; i < noOfLives; i++)
        {
            GameObject heart = Instantiate(heartPrefab, heartsParent);
            hearts.Add(heart);
        }
    }

    public void LoseLife()
    {
        if (noOfLives > 0)
        {
            noOfLives--;

            if (hearts.Count > 0)
            {
                GameObject lastHeart = hearts[hearts.Count - 1];
                hearts.RemoveAt(hearts.Count - 1);
                Destroy(lastHeart);
            }

            if (noOfLives == 0)
            {
                endPanel.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }



public void resetHealth()
    {
        this.noOfLives = 3;
    }
}
