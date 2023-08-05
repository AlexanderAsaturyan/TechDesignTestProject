using Assets.Scripts.Controllers;
using UnityEngine;

public class GirlAnimationController : MonoBehaviour
{
    [SerializeField] private GirlController girlController;
    [SerializeField] private BoxCollider2D boxCollider;
    
    private GirlAudioController audioController;

    public void SetGirlAudioController(GirlAudioController audioController)
    {
        this.audioController = audioController;
    }

    private void OnMouseUp()
    {
        StartCoroutine(girlController.Animate());
        audioController.PlayMusicAudio();
        audioController.PlayFootStepAudio();
        boxCollider.enabled = false;
    }
}
