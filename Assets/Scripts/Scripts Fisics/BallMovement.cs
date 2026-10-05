using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] private GamesettingsBallSO GamesettingsBall;
    [SerializeField] private float speedIncreasePerHit = 0.5f; // Incremento de velocidad por rebote
    [SerializeField] private float maxSpeed = 20f; // Velocidad máxima de la bola
    [SerializeField] private float speed=0f;
    private Vector2 starPos;
    private Rigidbody2D rb;
    private void Awake()
    {
     rb= GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        starPos = GamesettingsBall.StartPosition;  
        transform.position = starPos;           // Inicializa la posición de la bola desde el SO
        speed = GamesettingsBall.Speed;         // Inicializa la velocidad de la bola desde el SO
        Launch();
    }
    public void ResetBall()        // Método para reiniciar la posición y velocidad de la bola
    {
        transform.position = starPos;
        rb.linearVelocity = Vector2.zero;
        speed = GamesettingsBall.Speed;         // Inicializa la velocidad de la bola desde el SO
        Launch();
    }
    public void Launch()       // Método para lanzar la bola en una dirección aleatoria
    {
        float x = Random.Range(0,2)== 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        Vector2 direction = new Vector2(x, y).normalized;
        rb.linearVelocity = direction * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Aumenta la velocidad manteniendo la dirección del rebote
        speed = Mathf.Min(speed + speedIncreasePerHit, maxSpeed);
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }
}
