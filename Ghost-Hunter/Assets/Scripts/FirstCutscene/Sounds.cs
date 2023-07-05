using UnityEngine;

public class Sounds : MonoBehaviour
{
	private AudioSource audioSource;

	// TODO make this private and serialized
	public AudioClip audioClip;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void PlaySound()
	{
		audioSource.volume = Random.Range(0.8f, 1f);
		audioSource.pitch = Random.Range(0.95f, 1.05f);
		audioSource.Play();
	}

	public void ChangePlaySound()
	{
		audioSource.clip = audioClip;
		audioSource.Play();
	}
}
