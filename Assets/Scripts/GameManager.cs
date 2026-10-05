using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameSettingsSO GameSettings;
    [SerializeField] private EventGoal EventGoal;
    [SerializeField] public GameObject player1;
    [SerializeField] public GameObject player2;
    [SerializeField] public GameObject ball;
    [SerializeField] public GameObject goalPlayer1;
    [SerializeField] public  GameObject goalPlayer2;
    [SerializeField] public TMP_Text scoreTextPlayer1;
    [SerializeField] public TMP_Text scoreTextPlayer2;
    [SerializeField] public TMP_Text timer;
    [SerializeField] private int scorePlayer1 = 0;
    [SerializeField] private int scorePlayer2 = 0;


    public void Player1Goal()      // Método para actualizar el marcador del jugador 1 y reiniciar las posiciones
    {
        scorePlayer1++;
        scoreTextPlayer1.text = scorePlayer1.ToString();
        if (scorePlayer1 >= GameSettings.scoreToWin) // Compara si el score es el mismo al del Game settings
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
        if (scorePlayer2 >= GameSettings.scoreToWin) // Compara si el score es el mismo al del Game settings
        {
            EventGoal.GetComponent<EventGoal>().PlayerWin("Player 2");
            return;
        }
        EventGoal.ResetPositions();
        StartCoroutine(EventGoal.PauseGoal());
    }



}
