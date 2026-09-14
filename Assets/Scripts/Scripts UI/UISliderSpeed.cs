using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISliderSpeed : MonoBehaviour
{
    [Header("Referencia al asset compartido")]
    [SerializeField] private GameSettingsPlayerSO GameSettingsPlayer1;
    [SerializeField] private GameSettingsPlayerSO GameSettingsPlayer2;

    [Header("Player 1 Settings")]
    [SerializeField] private Slider Speed_player1;
    [SerializeField] private TMP_Text textSpeed_player1;
    [SerializeField] private Movement player1Movement; // referencia directa al Player 1 en la escena

    [Header("Player 2 Settings")]
    [SerializeField] private Slider Speed_player2;
    [SerializeField] private TMP_Text textSpeed_player2;
    [SerializeField] private Movement player2Movement; // referencia directa al Player 2 en la escena

    private void Awake()
    {
        Speed_player1.onValueChanged.AddListener(OnSpeedPlayer1);
        Speed_player2.onValueChanged.AddListener(OnSpeedPlayer2);
    }

    private void Start()
    {
        Speed_player1.value = GameSettingsPlayer1.speed;
        Speed_player2.value = GameSettingsPlayer2.speed;
        textSpeed_player1.text = GameSettingsPlayer1.speed.ToString("F2");
        textSpeed_player2.text = GameSettingsPlayer2.speed.ToString("F2");
    }
    private void OnDestroy()
    {
        Speed_player1.onValueChanged.RemoveListener(OnSpeedPlayer1);
        Speed_player2.onValueChanged.RemoveListener(OnSpeedPlayer2);
    }

    private void OnSpeedPlayer1(float value)
    {
        GameSettingsPlayer1.speed = value;
        textSpeed_player1.text = value.ToString("F2");
    }

    private void OnSpeedPlayer2(float value)
    {
        GameSettingsPlayer2.speed = value;
        textSpeed_player2.text = value.ToString("F2");
    }
}