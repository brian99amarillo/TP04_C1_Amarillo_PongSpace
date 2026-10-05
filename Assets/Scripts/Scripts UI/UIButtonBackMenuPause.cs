using UnityEngine;
using UnityEngine.UI;

public class UIButtonBackMenuPause : MonoBehaviour
{
    [SerializeField] private UIMenuPause UIMenuPause; // Referencia al script UIMenuPause para acceder a la variable isPause
    [Header("Back Buttons")]
    [SerializeField] private Button btnBackSettings; // Boton Back desde settings del menu de pausa
    [SerializeField] private Button btnBackCreditts; // Boton Back desde creditos del menu de pausa

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
        UIMenuPause.ReturnToPauseMenu();
    }

    private void OnBackButtonCredittsClicked()
    {
        UIMenuPause.ReturnToPauseMenu();
    }
}
