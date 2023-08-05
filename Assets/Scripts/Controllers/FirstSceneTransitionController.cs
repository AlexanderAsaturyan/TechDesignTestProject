using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstSceneTransitionController : MonoBehaviour
{
     private Canvas canvas;
     private Button button;

    private void Start()
    {
        button.onClick.AddListener(OpenSecondScene);
    }

    public void SetCanvasAndButton(Canvas canvas, Button button)
    {
        this.canvas = canvas;
        this.button = button;
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
