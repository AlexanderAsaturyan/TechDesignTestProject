using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private BirdController birdController;
    [SerializeField] private AudioController audioController;
    [SerializeField] private BoxCollider2D boxCollider;

    private void OnMouseUp()
    {
        Debug.Log("Click detected");
        StartCoroutine(birdController.Animate());      
        audioController.PlayMusicAudio();
        audioController.PlayBirdVoiceAudio();
        audioController.PlayFlapAudio();
        boxCollider.enabled = false;
    }
}
