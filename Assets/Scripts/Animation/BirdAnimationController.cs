using UnityEngine;

public class BirdAnimationController : MonoBehaviour
{
    [SerializeField] private BirdController birdController;
    [SerializeField] private BoxCollider2D boxCollider;

    private BirdAudioController audioController;

    public void SetBirdAudioController(BirdAudioController audioController)
    {
        this.audioController = audioController;
    }

    private void OnMouseUp()
    {
        StartCoroutine(birdController.Animate());      
        audioController.PlayMusicAudio();
        audioController.PlayBirdVoiceAudio();
        audioController.PlayFlapAudio();
        boxCollider.enabled = false;
    }
}
