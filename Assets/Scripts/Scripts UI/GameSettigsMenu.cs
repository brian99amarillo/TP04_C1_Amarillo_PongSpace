using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameSettigsMenu : MonoBehaviour
{
    [SerializeField] private GameSettingsSO GameSettings;

    [Header("Rondas para ganar")]
    [SerializeField] private Slider sliderRound;
    [SerializeField] private TMP_Text textRound;

    [Header("Tiempo por ronda")]
    [SerializeField] private Slider sliderTime;
    [SerializeField] private TMP_Text textTime;

    private void Awake()
    {
        sliderRound.onValueChanged.AddListener(OnRondasChanged);
        sliderTime.onValueChanged.AddListener(OnTiempoChanged);
    }

    private void OnDestroy()
    {
        sliderRound.onValueChanged.RemoveListener(OnRondasChanged);
        sliderTime.onValueChanged.RemoveListener(OnTiempoChanged);
    }

    private void Start()
    {
        // Inicializa los sliders con los valores actuales del SO
        sliderRound.SetValueWithoutNotify(GameSettings.ScoreToWin);
        textRound.text = GameSettings.ScoreToWin.ToString();

        sliderTime.SetValueWithoutNotify(GameSettings.MatchDuration); // corregido
        textTime.text = GameSettings.MatchDuration.ToString("F0");
    }

    private void OnRondasChanged(float value)
    {
        GameSettings.ScoreToWin = (int)value;
        textRound.text = ((int)value).ToString();
    }

    private void OnTiempoChanged(float value)
    {
        GameSettings.MatchDuration = value;
        textTime.text = value.ToString("F0");
    }
}

