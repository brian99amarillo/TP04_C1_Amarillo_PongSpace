using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameSettingsSO GameSettings;
    [SerializeField] private EventGoal EventGoal;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject goalPlayer1;
    [SerializeField] private  GameObject goalPlayer2;
    [SerializeField] private TMP_Text scoreTextPlayer1;
    [SerializeField] private TMP_Text scoreTextPlayer2;
    [SerializeField] private TMP_Text timer;
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject Player1 => player1;
    public GameObject Player2 => player2;
    public GameObject Ball => ball;
    
    public void Player1Goal()      // Método para actualizar el marcador del jugador 1 y reiniciar las posiciones
    {
        scorePlayer1++;
        scoreTextPlayer1.text = scorePlayer1.ToString();
        if (scorePlayer1 >= GameSettings.ScoreToWin) // Compara si el score es el mismo al del Game settings
        {
            EventGoal.GetComponent<EventGoal>().PlayerWin("Player 1");
            return;
        }
        EventGoal.ResetPositions();
        StartCoroutine(EventGoal.PauseGoal());
    }

    public void Player2Goal()      // Método para actualizar el marcador del jugador 2 y reiniciar las posiciones
    {
        scorePlayer2++;
        scoreTextPlayer2.text = scorePlayer2.ToString();
        if (scorePlayer2 >= GameSettings.ScoreToWin) // Compara si el score es el mismo al del Game settings
        {
            EventGoal.GetComponent<EventGoal>().PlayerWin("Player 2");
            return;
        }
        EventGoal.ResetPositions();
        StartCoroutine(EventGoal.PauseGoal());
    }
}
