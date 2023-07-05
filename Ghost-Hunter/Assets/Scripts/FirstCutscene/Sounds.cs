using UnityEngine;

public class Sounds : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void play_sound()
    {
        audioSource.volume = Random.Range(0.8f, 1f);
        audioSource.pitch = Random.Range(0.95f, 1.05f);
        audioSource.Play();
    }

    public void change_play_sound()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
