using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstSceneTransitionController : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(OpenSecondScene);
    }

    private void OnMouseUp()
    {
       // button.gameObject.SetActive(true);
        canvas.gameObject.SetActive(true);
    }

    private void OpenSecondScene()
    {
        SceneManager.LoadScene(1);
    }
}
