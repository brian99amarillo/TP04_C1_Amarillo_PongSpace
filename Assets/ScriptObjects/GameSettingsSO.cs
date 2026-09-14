using UnityEngine;

[CreateAssetMenu(fileName = "Gamesettings", menuName = "Settings/Gamesettings")]
public class GameSettingsSO : ScriptableObject
{
    [SerializeField] public int scoreToWin = 3;
    [SerializeField] public float matchDuration = 20f;
    [SerializeField] public float coldown = 2f;
}
