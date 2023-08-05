using UnityEngine;
using UnityEngine.UI;

public class SecondScenePrefabInstantiator : MonoBehaviour
{
    [SerializeField] private GirlAnimationController girlAnimationControllerPrefab;
    [SerializeField] private GirlAudioController girlAudioController;
    [SerializeField] private SecondSceneTransitionController transitionControllerPrefab;
    [SerializeField] private Canvas canvas;
    [SerializeField] private Button button;

    private void Start()
    {
        GirlAnimationController girlAnimationControllerGO = Instantiate(girlAnimationControllerPrefab);
        girlAnimationControllerGO.SetGirlAudioController(girlAudioController);
        SecondSceneTransitionController transitionControllerGO = Instantiate(transitionControllerPrefab);
        transitionControllerGO.SetCanvasAndButton(canvas, button);
    }
}
