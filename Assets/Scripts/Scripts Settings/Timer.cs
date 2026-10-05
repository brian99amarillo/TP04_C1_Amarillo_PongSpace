using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private GameSettingsSO GameSettings;
    [SerializeField] private GameManager GameManager;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private Transform ball;
 
    private float timer = 0f;
    private void Start()
    {
        timer = GameSettings.MatchDuration; // tiempo inicial, tomado del SO
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Goal();
            timer = GameSettings.MatchDuration;
        }
        timerText.text = "" + timer.ToString("F1");
    }

    private void Goal()
    {
        if (ball.position.x > 0)
        {
            GameManager.Player1Goal();
        }
        else
        {
            GameManager.Player2Goal();
        }
    }

    public void ResetTimer()
    {
        timer = GameSettings.MatchDuration;
    }
}
