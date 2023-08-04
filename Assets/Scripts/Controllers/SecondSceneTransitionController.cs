using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondSceneTransitionController : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(OpenFirstScene);
    }

    private void OnMouseUp()
    {
        button.gameObject.SetActive(true);
        canvas.gameObject.SetActive(true);
    }

    private void OpenFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
