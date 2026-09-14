using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISliderHeight: MonoBehaviour
{

    [Header("Referencia al asset compartido")]
    [SerializeField] private GameSettingsPlayerSO GameSettingsPlayer1;
    [SerializeField] private GameSettingsPlayerSO GameSettingsPlayer2;


    [Header("Player 1 Settings")]
    [SerializeField] private Slider Height_player1;
    [SerializeField] private TMP_Text textHeight_player1;

    [SerializeField] private Movement player1Movement; // referencia directa al Player 1 en la escena

    [Header("Player 2 Settings")]
    [SerializeField] private Slider Height_player2;
    [SerializeField] private TMP_Text textHeight_player2;

    [SerializeField] private Movement player2Movement; // referencia directa al Player 2 en la escena

    private void Awake()
    {
        //Valores de height de los player
        Height_player1.onValueChanged.AddListener(OnHeightPlayer1);
        Height_player2.onValueChanged.AddListener(OnHeightPlayer2);
    }

   
    private void Start()            // Metodo que se ejecuta al iniciar el juego, para aplicar los valores de height guardados en el asset
    {
        Height_player1.value = GameSettingsPlayer1.height;
        Height_player2.value = GameSettingsPlayer2.height;
        textHeight_player1.text = GameSettingsPlayer1.height.ToString("F2");
        textHeight_player2.text = GameSettingsPlayer2.height.ToString("F2");

        Vector3 escala1 = player1Movement.transform.localScale;     // Obtiene la escala actual del player 1
        escala1.y = GameSettingsPlayer1.height;                   // Actualiza la escala en el eje x con el valor guardado en el asset
        player1Movement.transform.localScale = escala1;             // Aplica la nueva escala al player 1

        Vector3 escala2 = player2Movement.transform.localScale;     // Obtiene la escala actual del player 2
        escala2.y = GameSettingsPlayer2.height;                   // Actualiza la escala en el eje x con el valor guardado en el asset
        player2Movement.transform.localScale = escala2;             // Aplica la nueva escala al player 2
    }

    private void OnDestroy()
    {
        Height_player1.onValueChanged.RemoveListener(OnHeightPlayer1);
        Height_player2.onValueChanged.RemoveListener(OnHeightPlayer2);
    }
    private void OnHeightPlayer1(float value)       // Metodo que se ejecuta cuando el slider del player 1 cambia de valor
    {
        GameSettingsPlayer1.height = value;                     // Actualiza el valor en el asset compartido
        textHeight_player1.text = value.ToString("F2");           // Actualiza el texto del slider

        Vector3 escala = player1Movement.transform.localScale;     // Obtiene la escala actual del player 1
        escala.y = value;                                          // Actualiza la escala en el eje x con el valor del slider
        player1Movement.transform.localScale = escala;             // Aplica la nueva escala al player 1
    }
    private void OnHeightPlayer2(float value)       // Metodo que se ejecuta cuando el slider del player 2 cambia de valor
    {
        GameSettingsPlayer2.height = value;                       // Actualiza el valor en el asset compartido
        textHeight_player2.text = value.ToString("F2");             // Actualiza el texto del slider

        Vector3 escala = player2Movement.transform.localScale;      // Obtiene la escala actual del player 2
        escala.y = value;                                           // Actualiza la escala en el eje x con el valor del slider
        player2Movement.transform.localScale = escala;              // Aplica la nueva escala al player 2
    }
}
