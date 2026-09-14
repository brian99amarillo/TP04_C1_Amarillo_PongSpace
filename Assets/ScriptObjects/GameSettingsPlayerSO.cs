using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsPlayer", menuName = "Settings/GameSettingsPlayer")]
public class GameSettingsPlayerSO : ScriptableObject
{
    [SerializeField] public KeyCode moveUp = KeyCode.W;
    [SerializeField] public KeyCode moveDown = KeyCode.S;
    [SerializeField] public KeyCode moveLeft = KeyCode.A;
    [SerializeField] public KeyCode moveRight = KeyCode.D;

    [Header("Velocidad de los jugadores")]
    [SerializeField] public float speed = 1f;

    [Header("Altura de los jugadores")]
    [SerializeField] public float height = 0.5f;

    [Header("Color de los jugadores")]
    [SerializeField] public Color color = Color.white;

    [Header("Posición inicial de los players")]
    [SerializeField] public Vector2 startPosition = new Vector2(0, 0);

    [Header("Límites de movimiento de los players")]
    [SerializeField] public float minX = 0f;
    [SerializeField] public float maxX = 0f;
    [SerializeField] public float minY = 0f;
    [SerializeField] public float maxY = 0f;

}