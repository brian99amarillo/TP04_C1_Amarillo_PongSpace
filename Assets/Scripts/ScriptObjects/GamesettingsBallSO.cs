using UnityEngine;

[CreateAssetMenu(fileName = "GamesettingsBall", menuName = "Settings/GamesettingsBall")]
public class GamesettingsBallSO : ScriptableObject
{
    [Header("Velocidad inicial de la bola")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private Vector2 startPosition = Vector2.zero;
    public float Speed => speed;
    public Vector2 StartPosition => startPosition;
}
