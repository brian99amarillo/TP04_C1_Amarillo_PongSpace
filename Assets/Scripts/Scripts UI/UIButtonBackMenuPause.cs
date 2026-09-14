using UnityEngine;
using UnityEngine.UI;

public class UIButtonBackMenuPause : MonoBehaviour
{
    [Header("Back Buttons")]
    [SerializeField] private Button btnBackSettings; // Boton Back desde settings del menu de pausa
    [SerializeField] private Button btnBackCreditts; // Boton Back desde creditos del menu de pausa

    [Header("Panels")]
    [SerializeField] private GameObject MenuPause;
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
        MenuPause.SetActive(true);
        SettingsPanel.SetActive(false);
    }

    private void OnBackButtonCredittsClicked()
    { 
        MenuPause.SetActive(true);
        CredittsPanel.SetActive(false);
    }
}
