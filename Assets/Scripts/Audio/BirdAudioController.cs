using UnityEngine;

public class BirdAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource musicAudio;
    [SerializeField] private AudioSource birdVoiceAudio;
    [SerializeField] private AudioSource flapAudio;

    public void PlayMusicAudio()
    {
        musicAudio.Play();
    }

    public void PlayBirdVoiceAudio()
    {
        birdVoiceAudio.Play();
    }
    public void PlayFlapAudio()
    {
        flapAudio.Play();
    }
}
