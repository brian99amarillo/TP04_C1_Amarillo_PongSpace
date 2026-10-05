using UnityEngine;

[CreateAssetMenu(fileName = "GameSettingsPlayer", menuName = "Settings/GameSettingsPlayer")]
public class GameSettingsPlayerSO : ScriptableObject
{
    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveDown = KeyCode.S;
    [SerializeField] private KeyCode moveLeft = KeyCode.A;
    [SerializeField] private KeyCode moveRight = KeyCode.D;

    [Header("Velocidad de los jugadores")]
    [SerializeField] private float speed = 1f;

    [Header("Altura de los jugadores")]
    [SerializeField] private float height = 0.5f;

    [Header("Color de los jugadores")]
    [SerializeField] private Color color = Color.white;

    [Header("Posición inicial de los players")]
    [SerializeField] private Vector2 startPosition = new Vector2(0, 0);

    [Header("Límites de movimiento de los players")]
    [SerializeField] private float minX = 0f;
    [SerializeField] private float maxX = 0f;
    [SerializeField] private float minY = 0f;
    [SerializeField] private float maxY = 0f;


    public KeyCode MoveUp => moveUp;
    public KeyCode MoveDown => moveDown;
    public KeyCode MoveLeft => moveLeft;
    public KeyCode MoveRight => moveRight;
    public Vector2 StartPosition => startPosition;
    public float MinX => minX;
    public float MaxX => maxX;
    public float MinY => minY;
    public float MaxY => maxY;
    public float Speed
    {
        get => speed;
        set => speed = value;
    }
    public float Height
    {
        get => height;
        set => height = value;
    }
    public Color Color
    { 

    get => color;
    set => color = value;
    }

}