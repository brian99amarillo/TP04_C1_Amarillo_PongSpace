using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Controles de Movimiento")]
    [SerializeField] private GameSettingsPlayerSO GameSettingsPlayer; // mismo asset arrastrado acá también
    private Rigidbody2D rb;
    private Vector2 startPos;

    private void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    private void Start()
    {   
        startPos = GameSettingsPlayer.StartPosition;     // Inicializa la posición del jugador desde el asset compartido
        transform.position = startPos;                   
        GetComponent<SpriteRenderer>().color = GameSettingsPlayer.Color;    // Inicializa el color del jugador desde el asset compartido
        transform.localScale = new Vector3(transform.localScale.x, GameSettingsPlayer.Height, transform.localScale.z);  // Inicializa la altura del jugador desde el asset compartido
    }

    public void ResetPosicionPlayer()        // Método para reiniciar la posición y velocidad de los jugadores
    {
        transform.position = startPos;
        rb.linearVelocity = Vector2.zero;
    }
    private void FixedUpdate()
    {
        // Movimiento con Rigidbody2D del player 
        if (Input.GetKey(GameSettingsPlayer.MoveUp)) // Si la tecla W está presionada el objeto se mueve hacia arriba
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, GameSettingsPlayer.Speed);
        }
        if (Input.GetKey(GameSettingsPlayer.MoveDown)) // Si la tecla S está presionada el objeto se mueve hacia abajo
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -GameSettingsPlayer.Speed);
        }
        if (Input.GetKey(GameSettingsPlayer.MoveLeft)) // Si la tecla A está presionada el objeto se mueve hacia la izquierda
        {
            rb.linearVelocity = new Vector2(-GameSettingsPlayer.Speed, rb.linearVelocity.y);
        }
        if (Input.GetKey(GameSettingsPlayer.MoveRight)) // Si la tecla D está presionada el objeto se mueve hacia la derecha
        {
            rb.linearVelocity = new Vector2(GameSettingsPlayer.Speed, rb.linearVelocity.y);
        }
    }
}   