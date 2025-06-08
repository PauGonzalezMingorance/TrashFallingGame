using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	// Reference the GameManager.Instance to retrieve its difficulty setting
	public void PlayGame()
	{
		// Access GameManager.Instance.difficulty and load the corresponding scene
		string difficulty = GameManager.Instance.difficulty;

		if (difficulty == "Easy")
		{
			SceneManager.LoadSceneAsync(1); // Replace 1 with the Easy scene index
		}
		else if (difficulty == "Medium")
		{
			SceneManager.LoadSceneAsync(2); // Replace 2 with the Medium scene index
		}
		else if (difficulty == "Hard")
		{
			SceneManager.LoadSceneAsync(3); // Replace 3 with the Hard scene index
		}
	}

	// QuitGame Method: Close the game
	public void QuitGame()
	{
		Application.Quit();
	}

	// GoMainMenu Method: Return to the Main Menu
	public void GoMainMenu()
	{
		SceneManager.LoadSceneAsync(0); // Replace 0 with the Main Menu scene index
	}
}
