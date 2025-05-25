using UnityEngine;
using UnityEngine.UI;

public class soundButton : MonoBehaviour
{
    public Sprite defaultSprite;
    public Sprite clickedSprite;

    private Image buttonImage;

    void Start()
    {
        buttonImage = GetComponent<Image>(); // Obtiene el componente Image del botón
        if (buttonImage == null)
        {
            Debug.LogError("El objeto no tiene un componente Image. Por favor, asegúrate de que el botón tenga un componente Image.");
        }
    }

    public void OnClick()
    {
        if(buttonImage.sprite == defaultSprite)
        {
            // Cambia la imagen del botón a la imagen de clic
            buttonImage.sprite = clickedSprite;
        }
        else
        {
            buttonImage.sprite = defaultSprite;
        }
    }
}