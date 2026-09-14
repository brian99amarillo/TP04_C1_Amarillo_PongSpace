using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private GameSettingsSO GameSettings;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private Transform ball;
    [SerializeField] private EventGoal eventGoal; // referencia al script que maneja los goles

    public float timer = 0f;
    private void Start()
    {
        timer = GameSettings.matchDuration; // tiempo inicial, tomado del SO
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Goal();
            timer = GameSettings.matchDuration;
        }
        timerText.text = "" + timer.ToString("F1");
    }

    private void Goal()
    {
        if (ball.position.x > 0)
        {
            eventGoal.Player1Goal();
        }
        else
        {
            eventGoal.Player2Goal();
        }
    }

    public void ResetTimer()
    {
        timer = GameSettings.matchDuration;
    }
}
