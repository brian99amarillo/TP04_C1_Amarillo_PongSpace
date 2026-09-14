using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameSettigsMenu : MonoBehaviour
{
    [SerializeField] private GameSettingsSO GameSettings;

    [Header("Rondas para ganar")]
    [SerializeField] private Slider sliderRondas;
    [SerializeField] private TMP_Text textRondas;

    [Header("Tiempo por ronda")]
    [SerializeField] private Slider sliderTiempo;
    [SerializeField] private TMP_Text textTiempo;

    private void Awake()
    {
        sliderRondas.onValueChanged.AddListener(OnRondasChanged);
        sliderTiempo.onValueChanged.AddListener(OnTiempoChanged);
    }

    private void OnDestroy()
    {
        sliderRondas.onValueChanged.RemoveListener(OnRondasChanged);
        sliderTiempo.onValueChanged.RemoveListener(OnTiempoChanged);
    }

    private void Start()
    {
        // Inicializa los sliders con los valores actuales del SO
        sliderRondas.SetValueWithoutNotify(GameSettings.scoreToWin);
        textRondas.text = GameSettings.scoreToWin.ToString();

        sliderTiempo.SetValueWithoutNotify(GameSettings.matchDuration); // corregido
        textTiempo.text = GameSettings.matchDuration.ToString("F0");
    }

private void OnRondasChanged(float value)
    {
        GameSettings.scoreToWin = (int)value;
        textRondas.text = ((int)value).ToString();
    }

    private void OnTiempoChanged(float value)
    {
        GameSettings.matchDuration = value;
        textTiempo.text = value.ToString("F0");
    }
}

