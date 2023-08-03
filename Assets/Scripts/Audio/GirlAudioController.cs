using UnityEngine;

public class GirlAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource musicAudio;
    [SerializeField] private AudioSource footStepAudio;

    public void PlayMusicAudio()
    {
        musicAudio.Play();
    }

    public void PlayFootStepAudio()
    {
        footStepAudio.Play();
    }
}
