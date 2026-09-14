using UnityEngine;
using UnityEngine.UI;

public class UIButtonBackMainMenu : MonoBehaviour
{
    [Header("Back Buttons")]
    [SerializeField] private Button btnBackSettings; // Boton Back desde settings del menu de pausa
    [SerializeField] private Button btnBackCreditts; // Boton Back desde creditos del menu de pausa

    [Header("Panels")]
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject CredittsPanel;

    private void Awake()
    {
        // Botones de volver
        btnBackSettings.onClick.AddListener(OnBackButtonSettingsClicked);  // Back de settings
        btnBackCreditts.onClick.AddListener(OnBackButtonCredittsClicked); // Back de los creditos
    }

    private void OnDestroy()
    {
        btnBackSettings.onClick.RemoveListener(OnBackButtonSettingsClicked);
        btnBackCreditts.onClick.RemoveListener(OnBackButtonCredittsClicked);
    }

    private void OnBackButtonSettingsClicked()
    {
        Menu.SetActive(true);
        SettingsPanel.SetActive(false);
    }

    private void OnBackButtonCredittsClicked()
    {        
        Menu.SetActive(true);
        CredittsPanel.SetActive(false);
    }
}
