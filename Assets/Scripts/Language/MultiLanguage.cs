using UnityEngine;
using Assets.SimpleLocalization.Scripts;
using UnityEngine.UI;

public class MultiLanguage : MonoBehaviour
{
    [SerializeField] private Button enButton;
    [SerializeField] private Button esButton;
    [SerializeField] private Button ruButton;

    private void Awake()
    {
        LocalizationManager.Read();
        LocalizationManager.Language = "English";
    }

    private void Start()
    {
        enButton.onClick.AddListener(MakeEnglish);
        esButton.onClick.AddListener(MakeSpanish);
        ruButton.onClick.AddListener(MakeRussian);
    }

    private void MakeEnglish()
    {
        LocalizationManager.Language = "English";
    }

    private void MakeSpanish()
    {
        LocalizationManager.Language = "Spanish";
    }
    private void MakeRussian()
    {
        LocalizationManager.Language = "Russian";
    }
}
