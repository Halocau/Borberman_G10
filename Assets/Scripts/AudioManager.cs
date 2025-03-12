using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // tao bien luu tru audio source
    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    // tao bien luu tru audio clip
    public AudioClip musicClip;//nhac nen
    public AudioClip itemClip;//am thanh khi an item
    public AudioClip gameOverClip;//am thanh khi game over

    void Start()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }
    //goi hieu ung am thanh
    public void PlaySFX(AudioClip sfxClip)
    {
        vfxAudioSource.clip = sfxClip;
        vfxAudioSource.PlayOneShot(sfxClip);// phat 1 lan
    }
}
