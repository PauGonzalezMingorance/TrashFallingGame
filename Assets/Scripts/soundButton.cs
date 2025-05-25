using UnityEngine;
using UnityEngine.UI;

public class soundButton : MonoBehaviour
{
    public Sprite defaultSprite;
    public Sprite clickedSprite;

    private Image buttonImage;

    void Start()
    {
        buttonImage = GetComponent<Image>(); // Obtiene el componente Image del bot�n
        if (buttonImage == null)
        {
            Debug.LogError("El objeto no tiene un componente Image. Por favor, aseg�rate de que el bot�n tenga un componente Image.");
        }
    }

    public void OnClick()
    {
        if(buttonImage.sprite == defaultSprite)
        {
            // Cambia la imagen del bot�n a la imagen de clic
            buttonImage.sprite = clickedSprite;
        }
        else
        {
            buttonImage.sprite = defaultSprite;
        }
    }
}