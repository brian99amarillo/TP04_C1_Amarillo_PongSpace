using UnityEngine;

[CreateAssetMenu(fileName = "Gamesettings", menuName = "Settings/Gamesettings")]
public class GameSettingsSO : ScriptableObject
{
    [SerializeField] private int scoreToWin = 3;
    [SerializeField] private float matchDuration = 20f;
    [SerializeField] private float cooldown = 2f;

    public int ScoreToWin
    {
        get => scoreToWin;
        set => scoreToWin = value;
    }

    public float MatchDuration
    {
        get => matchDuration;
        set => matchDuration = value;
    }

    public float Cooldown
    {
        get => cooldown;
        set => cooldown = value;
    }
}
