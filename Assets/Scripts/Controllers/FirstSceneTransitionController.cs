using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstSceneTransitionController : MonoBehaviour
{
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(OpenSecondScene);
    }

    private void OnMouseUp()
    {
        button.gameObject.SetActive(true);
    }

    private void OpenSecondScene()
    {
        SceneManager.LoadScene(1);
    }
}
