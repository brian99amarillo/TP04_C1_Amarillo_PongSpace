using System.Collections;
using UnityEngine;
using TMPro;

public class EventGoal : MonoBehaviour
{
    [SerializeField] private GameObject GameManager;
    [SerializeField] private GameSettingsSO GameSettings;
    [SerializeField] private TMP_Text PlayerWinner;
    [SerializeField] private Timer timer;

    [SerializeField] private GameObject WinPanel;
    public float coldown = 2f;
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Ball"))                           // Verifica si el objeto que colisiona tiene la etiqueta "Ball"
        {

            if (gameObject.CompareTag("GoalPlayer1"))               // Verifica si el objeto que colisiona tiene la etiqueta "GoalPlayer1"
            {
                Player1Goal(); 
            }
            else if (gameObject.CompareTag("GoalPlayer2"))          // Verifica si el objeto que colisiona tiene la etiqueta "GoalPlayer2"
            {
                Player2Goal();
            }
        }
    }

    public void Player1Goal()      // Método para actualizar el marcador del jugador 1 y reiniciar las posiciones
    {
        scorePlayer1++;
        GameManager.GetComponent<GameManager>().scoreTextPlayer1.text = scorePlayer1.ToString();
        if (scorePlayer1 >= GameSettings.scoreToWin) // Compara si el score es el mismo al del Game settings
        {
            PlayerWin("Player 1");
            return;
        }
        ResetPositions();
        StartCoroutine(PauseGoal());
    }

    public void Player2Goal()      // Método para actualizar el marcador del jugador 2 y reiniciar las posiciones
    {
        scorePlayer2++;
        GameManager.GetComponent<GameManager>().scoreTextPlayer2.text = scorePlayer2.ToString();
        if (scorePlayer2 >= GameSettings.scoreToWin)
        {
            PlayerWin("Player 2");
            return;
        }
        ResetPositions();
        StartCoroutine(PauseGoal());
    }

    private void ResetPositions()       // Método para reiniciar las posiciones de la bola y los jugadores
    {
        GameManager.GetComponent<GameManager>().ball.GetComponent<BallMovement>().ResetBall();
        GameManager.GetComponent<GameManager>().player1.GetComponent<Movement>().ResetPosicionPlayer();
        GameManager.GetComponent<GameManager>().player2.GetComponent<Movement>().ResetPosicionPlayer();
        timer.ResetTimer();
    }

    private void PlayerWin(string winnerName)   // Se activa un panel que muestra el player ganador
    {
        ResetPositions();
        Time.timeScale = 0f;
        PlayerWinner.text = $"{winnerName} Wins!";
        WinPanel.SetActive(true);
    } 

    private IEnumerator PauseGoal()     // Hace una pausa de 2 segundos en el gameplay despues de cada gol
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(coldown);
        Time.timeScale = 1f;
    }
}
