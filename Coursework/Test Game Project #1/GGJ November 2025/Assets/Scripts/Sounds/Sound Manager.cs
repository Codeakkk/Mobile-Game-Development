using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //No other sound manager instance while we have this one
    public static SoundManager instance { get; private set; }
    private AudioSource source;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }
}
