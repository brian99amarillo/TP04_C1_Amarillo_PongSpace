using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [Header("Controles de Movimiento")]
    [SerializeField] private GameSettingsPlayerSO GameSettingsPlayer; // mismo asset arrastrado acá también
    private Rigidbody2D rb;
    private Vector2 starPos;

    private void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    private void Start()
    {   
        starPos = GameSettingsPlayer.startPosition;     // Inicializa la posición del jugador desde el asset compartido
        transform.position = starPos;                   
        GetComponent<SpriteRenderer>().color = GameSettingsPlayer.color;    // Inicializa el color del jugador desde el asset compartido
        transform.localScale = new Vector3(transform.localScale.x, GameSettingsPlayer.height, transform.localScale.z);  // Inicializa la altura del jugador desde el asset compartido
    }

    public void ResetPosicionPlayer()        // Método para reiniciar la posición y velocidad de los jugadores
    {
        transform.position = starPos;
        rb.linearVelocity = Vector2.zero;
    }
    private void FixedUpdate()
    {
        // Movimiento con Rigidbody2D del player 
        if (Input.GetKey(GameSettingsPlayer.moveUp)) // Si la tecla W está presionada el objeto se mueve hacia arriba
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, GameSettingsPlayer.speed);
        }
        if (Input.GetKey(GameSettingsPlayer.moveDown)) // Si la tecla S está presionada el objeto se mueve hacia abajo
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -GameSettingsPlayer.speed);
        }
        if (Input.GetKey(GameSettingsPlayer.moveLeft)) // Si la tecla A está presionada el objeto se mueve hacia la izquierda
        {
            rb.linearVelocity = new Vector2(-GameSettingsPlayer.speed, rb.linearVelocity.y);
        }
        if (Input.GetKey(GameSettingsPlayer.moveRight)) // Si la tecla D está presionada el objeto se mueve hacia la derecha
        {
            rb.linearVelocity = new Vector2(GameSettingsPlayer.speed, rb.linearVelocity.y);
        }
    }
}   