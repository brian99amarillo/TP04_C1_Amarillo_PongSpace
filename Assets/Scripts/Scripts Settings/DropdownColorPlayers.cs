using TMPro;
using UnityEngine;

public class DropdownColorPlayers : MonoBehaviour
{
    [Header("Player 1")]
    [SerializeField] private GameSettingsPlayerSO GameSettingsPlayer1;
    [SerializeField] private TMP_Dropdown dropdownPlayer1;

    [Header("Player 2")]
    [SerializeField] private GameSettingsPlayerSO GameSettingsPlayer2;
    [SerializeField] private TMP_Dropdown dropdownPlayer2;

    private void Awake()
    {
        dropdownPlayer1.onValueChanged.AddListener(OnColorPlayer1Changed);
        dropdownPlayer2.onValueChanged.AddListener(OnColorPlayer2Changed);
    }

    private void OnDestroy()
    {
        dropdownPlayer1.onValueChanged.RemoveListener(OnColorPlayer1Changed);
        dropdownPlayer2.onValueChanged.RemoveListener(OnColorPlayer2Changed);
    }

    public void OnColorPlayer1Changed(int colorSelect)
    {
        GameSettingsPlayer1.Color = ObtenerColor(colorSelect);
    }

    public void OnColorPlayer2Changed(int colorSelect)
    {
        GameSettingsPlayer2.Color = ObtenerColor(colorSelect);
    }

    private Color ObtenerColor(int colorSelect)
    {
        switch (colorSelect)
        {
            case 0: return Color.white;
            case 1: return Color.blue;
            case 2: return Color.green;
            case 3: return Color.red;
            case 4: return Color.yellow;
            default: return Color.white;
        }
    }
}