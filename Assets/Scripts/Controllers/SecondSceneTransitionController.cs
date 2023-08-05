using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondSceneTransitionController : MonoBehaviour
{
     private Canvas canvas;
     private Button button;

    private void Start()
    {
        button.onClick.AddListener(OpenFirstScene);
    }

    public void SetCanvasAndButton(Canvas canvas, Button button)
    {
        this.canvas = canvas;
        this.button = button;
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
