using UnityEngine;

[CreateAssetMenu(fileName = "GamesettingsBall", menuName = "Settings/GamesettingsBall")]
public class GamesettingsBallSO : ScriptableObject
{
    [Header("Velocidad inicial de la bola")]
    [SerializeField] public float speed = 5f;
    [SerializeField] public Vector2 startPosition = Vector2.zero;
}
