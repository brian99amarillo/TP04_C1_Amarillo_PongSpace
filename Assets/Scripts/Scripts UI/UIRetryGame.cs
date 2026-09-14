using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIRetryGame : MonoBehaviour
{
    [SerializeField] private Button btnRetry;

    [SerializeField] private GameObject PanelWinner;

    private void Awake()
    {
        btnRetry.onClick.AddListener(OnRetryButtonClicked);
    }

    private void OnDestroy()
    {
        btnRetry.onClick.RemoveListener(OnRetryButtonClicked);
    }

    private void OnRetryButtonClicked ()
    {
        PanelWinner.SetActive(false);
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
}
