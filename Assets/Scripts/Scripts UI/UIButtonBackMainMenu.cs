using UnityEngine;
using UnityEngine.UI;

public class UIButtonBackMainMenu : MonoBehaviour
{
    [Header("Back Buttons")]
    [SerializeField] private Button btnBackSettings; // Boton Back desde settings del menu de pausa
    [SerializeField] private Button btnBackCredits; // Boton Back desde creditos del menu de pausa

    [Header("Panels")]
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject CreditsPanel;

    private void Awake()
    {
        // Botones de volver
        btnBackSettings.onClick.AddListener(OnBackButtonSettingsClicked);  // Back de settings
        btnBackCredits.onClick.AddListener(OnBackButtonCreditsClicked); // Back de los creditos
    }

    private void OnDestroy()
    {
        btnBackSettings.onClick.RemoveListener(OnBackButtonSettingsClicked);
        btnBackCredits.onClick.RemoveListener(OnBackButtonCreditsClicked);
    }

    private void OnBackButtonSettingsClicked()
    {
        Menu.SetActive(true);
        SettingsPanel.SetActive(false);
    }

    private void OnBackButtonCreditsClicked()
    {        
        Menu.SetActive(true);
        CreditsPanel.SetActive(false);
    }
}
