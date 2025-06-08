using UnityEngine;
using UnityEngine.UI;

public class soundButton : MonoBehaviour
{
    public Sprite defaultSprite;
    public Sprite clickedSprite;
    public GameObject musicObject; 
    private AudioSource audioSource;
    private Image buttonImage;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        if (buttonImage == null)
        {
            Debug.LogError("The object doesn't have an Image component. Please make sure the button has an Image component.");
        }

        if (musicObject != null)
        {
            audioSource = musicObject.GetComponent<AudioSource>();
            if (audioSource == null)
            {
                Debug.LogError("The musicObject does not have an AudioSource component attached.");
            }
        }
        else
        {
            Debug.LogError("musicObject is not assigned. Please assign it in the Unity Inspector.");
        }
    }

    public void OnClick()
    {
        if (audioSource == null)
        {
            Debug.LogError("audioSource is. Please ensure musicObject is correctly assigned and contains an AudioSource component.");
            return;
        }

        if (buttonImage.sprite == defaultSprite)
        {
            buttonImage.sprite = clickedSprite;
            audioSource.mute = true;
        }
        else
        {
            buttonImage.sprite = defaultSprite;
            audioSource.mute = false;
        }
    }
}
