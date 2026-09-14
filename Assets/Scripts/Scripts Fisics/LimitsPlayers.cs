using UnityEngine;

public class LimitsPlayers : MonoBehaviour
{
    [SerializeField] private GameSettingsPlayerSO GameSettingsPlayer;
    [SerializeField] private float MinX;
    [SerializeField] private float MaxX;
    [SerializeField] private float MinY;
    [SerializeField] private float MaxY;

    [SerializeField] private Color colorOnLimit = Color.black;
    [SerializeField] private float colorDuration = 0.3f;
    private SpriteRenderer sr;
    private Color originalColor;
    private void Start()
    {
        MinX = GameSettingsPlayer.minX;
        MaxX = GameSettingsPlayer.maxX;
        MinY = GameSettingsPlayer.minY;
        MaxY = GameSettingsPlayer.maxY;
        sr = GetComponent<SpriteRenderer>();
        originalColor = sr.color;
    }
    private void FixedUpdate()
    {
        // Limita la posición del jugador en el eje X 
        Vector3 pos = transform.position;
       float clampedX = Mathf.Clamp(pos.x, MinX, MaxX);     // Limita la posición del jugador en el eje X 
        if (clampedX != pos.x)                              // Si la posición del jugador está fuera de los límites en el eje X cambia el color del jugador
        {
            sr.color = colorOnLimit;                        // Cambia el color del jugador al color definido en colorOnLimit
            Invoke(nameof(ResetColor), colorDuration);      
        }
        pos.x = clampedX;                                   // Asigna la posición limitada al jugador
        transform.position = pos;

        float clampedY = Mathf.Clamp(pos.y, MinY, MaxY);    // Limita la posición del jugador en el eje Y   
        if (clampedY != pos.y)                              // Si la posición del jugador está fuera de los límites en el eje Y cambia el color del jugador       
        {
            sr.color = colorOnLimit;                        // Cambia el color del jugador al color definido en colorOnLimit 
            Invoke(nameof(ResetColor), colorDuration);
        }
        pos.y = clampedY;                                   // Asigna la posición limitada al jugador
        transform.position = pos;
    }
    private void ResetColor()
    {
        sr.color = originalColor;                           // Vuelve a poner el color original al jugador
    }
}
