using UnityEngine;

public class ChangeColorPlayer : MonoBehaviour
{
    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();    // // Obtenemos el componente SpriteRenderer del mismo objeto
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            float r = Random.value;
            float g = Random.value;
            float b = Random.value;
            sr.color = new Color(r, g, b);
        }
    }

}