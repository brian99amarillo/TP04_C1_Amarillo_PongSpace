using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{

    [Header("Menu Pause Buttons")]
    [SerializeField] private Button btnPlay;        // Boton de continuar para volver al juego desde el menu de pausa
    [SerializeField] private Button btnSettings;    // Boton de opciones para abrir el panel de opciones desde el menu principa
    [SerializeField] private Button btnCredits;    // Boton de creditos para abrir el panel de creditos desde el menu principal
    [SerializeField] private Button btnExit;        // Boton de salir del juego desde el menu principal

    [Header("Panels & Scenes")]
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject CreditsPanel;

    private void Awake()  // Inicializacion de los botones y sliders
    {
        // Botones del menu principal
        btnPlay.onClick.AddListener(OnPlayButtonClicked);
        btnSettings.onClick.AddListener(OnSettingsButtonClicked);
        btnCredits.onClick.AddListener(OnCreditsButtonClicked);
        btnExit.onClick.AddListener(OnExitButtonClicked);
    }

    private void Start()
    {
        Time.timeScale = 1f;
    }
    private void OnDestroy() // Remueve los listeners inicializados en el Awake 
    {
        // Botones del menu de pausa
         btnPlay.onClick.RemoveListener(OnPlayButtonClicked);
         btnSettings.onClick.RemoveListener(OnSettingsButtonClicked);
         btnCredits.onClick.RemoveListener(OnCreditsButtonClicked);
         btnExit.onClick.RemoveListener(OnExitButtonClicked);

#if UNITY_WEBGL && !UNITY_EDITOR
    btnExit.gameObject.SetActive(false);
#endif
    }
    //Botones del Menu Principal
    private void OnPlayButtonClicked()  // Boton de play para cambiar la escena al juego
    {
        SceneManager.LoadScene("Game");     // Cambia a la escena del juego
    }
    private void OnSettingsButtonClicked() // Abre el panel de opciones desde el menu principal
    {
        Menu.SetActive(false);
        SettingsPanel.SetActive(true);
    }
    private void OnCreditsButtonClicked() // Abre el panel de los creditos desde el menu principal
    {
        Menu.SetActive(false);
        CreditsPanel.SetActive(true);
    }
    private void OnExitButtonClicked() // Metodo para salir del juego
    {
        Application.Quit();
#if UNITY_EDITOR
        // Dentro del editor: detiene el Play
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
