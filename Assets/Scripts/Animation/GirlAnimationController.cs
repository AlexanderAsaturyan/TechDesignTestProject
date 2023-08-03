using Assets.Scripts.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlAnimationController : MonoBehaviour
{
    [SerializeField] private GirlController girlController;
    [SerializeField] private GirlAudioController audioController;
    [SerializeField] private BoxCollider2D boxCollider;

    private void OnMouseUp()
    {
        StartCoroutine(girlController.Animate());
        audioController.PlayMusicAudio();
        audioController.PlayFootStepAudio();
        boxCollider.enabled = false;
    }
}
