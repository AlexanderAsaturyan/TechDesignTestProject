using UnityEngine;
using UnityEngine.UI;

public class FirstScenePrefabInstantiator : MonoBehaviour
{
    [SerializeField] private BirdAnimationController birdAnimationControllerPrefab;
    [SerializeField] private BirdAudioController birdAudioController;
    [SerializeField] private FirstSceneTransitionController transitionControllerPrefab;
    [SerializeField] private Canvas canvas;
    [SerializeField] private Button button;
    [SerializeField] private GameObject loopAnimation;

    private void Start()
    {
        BirdAnimationController birdAnimationControllerGO = Instantiate(birdAnimationControllerPrefab);
        birdAnimationControllerGO.SetBirdAudioController(birdAudioController);
        FirstSceneTransitionController transitionControllerGO = Instantiate(transitionControllerPrefab);
        transitionControllerGO.SetCanvasAndButton(canvas, button);
        Instantiate(loopAnimation);
    }
}
