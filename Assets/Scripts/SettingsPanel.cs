using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SettingsPanel : MonoBehaviour
{
	public ToggleGroup difficultyToggleGroup;
	public Toggle easyToggle;
	public Toggle mediumToggle;
	public Toggle hardToggle;

	void Start()
	{
		// Set the default toggle based on GameManager.Instance.difficulty
		string savedDifficulty = GameManager.Instance.difficulty;

		if (savedDifficulty == "Easy") easyToggle.isOn = true;
		else if (savedDifficulty == "Medium") mediumToggle.isOn = true;
		else if (savedDifficulty == "Hard") hardToggle.isOn = true;

		// Add listeners for toggles
		easyToggle.onValueChanged.AddListener(delegate { OnToggleChanged(); });
		mediumToggle.onValueChanged.AddListener(delegate { OnToggleChanged(); });
		hardToggle.onValueChanged.AddListener(delegate { OnToggleChanged(); });
	}

	private void OnToggleChanged()
	{
		// Get the active toggle from the ToggleGroup
		Toggle activeToggle = difficultyToggleGroup.ActiveToggles().FirstOrDefault();

		if (activeToggle != null)
		{
			// Update GameManager difficulty to match the active toggle name
			GameManager.Instance.difficulty = activeToggle.name;
			Debug.Log("Difficulty set to: " + GameManager.Instance.difficulty);
		}
	}
}
