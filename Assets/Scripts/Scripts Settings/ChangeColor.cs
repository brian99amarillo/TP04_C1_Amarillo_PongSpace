using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    [Header("Controles de Color")]
    [SerializeField] private KeyCode changeColorKey = KeyCode.R; // Tecla para cambiar el color
    private SpriteRenderer sr;
    private Color originalColor;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>(); // Obtenemos el componente SpriteRenderer del mismo objeto
        originalColor = sr.color;   // Guardamos el color original del objeto
    }
    private void Update()
    {
        // Cambio de color random
        float r = Random.value;
        float g = Random.value;
        float b = Random.value;

        if (Input.GetKeyUp(changeColorKey)) // Si la tecla R está presionada cambia de color
        {
            sr.color = new Color(r, g, b);
        }
    }
}
