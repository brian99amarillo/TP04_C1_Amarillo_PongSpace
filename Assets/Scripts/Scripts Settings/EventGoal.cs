using System.Collections;
using UnityEngine;
using TMPro;

public class EventGoal : MonoBehaviour
{
    [SerializeField] private GameObject GameManager;
    [SerializeField] private TMP_Text PlayerWinner;
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private float coldown = 2f;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Ball"))                           // Verifica si el objeto que colisiona tiene la etiqueta "Ball"
        {

            if (gameObject.CompareTag("GoalPlayer1"))               // Verifica si el objeto que colisiona tiene la etiqueta "GoalPlayer1"
            {
                GameManager.GetComponent<GameManager>().Player1Goal();
            }
            else if (gameObject.CompareTag("GoalPlayer2"))          // Verifica si el objeto que colisiona tiene la etiqueta "GoalPlayer2"
            {
                GameManager.GetComponent<GameManager>().Player2Goal();
            }
        }
    }

    public void ResetPositions()       // Método para reiniciar las posiciones de la bola y los jugadores
    {
        GameManager.GetComponent<GameManager>().ball.GetComponent<BallMovement>().ResetBall();
        GameManager.GetComponent<GameManager>().player1.GetComponent<Movement>().ResetPosicionPlayer();
        GameManager.GetComponent<GameManager>().player2.GetComponent<Movement>().ResetPosicionPlayer();
        timer.ResetTimer();
    }

    public void PlayerWin(string winnerName)   // Se activa un panel que muestra el player ganador
    {
        ResetPositions();
        Time.timeScale = 0f;
        PlayerWinner.text = $"{winnerName} Wins!";
        WinPanel.SetActive(true);
    } 

    public IEnumerator PauseGoal()     // Hace una pausa de 2 segundos en el gameplay despues de cada gol
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(coldown);
        Time.timeScale = 1f;
    }
}
