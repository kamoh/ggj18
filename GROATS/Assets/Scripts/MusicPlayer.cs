using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
	public AudioClip[] clips;
	private AudioSource audioSource;
	void Start () {
		audioSource = FindObjectOfType<AudioSource>();
		audioSource.loop = true;
	}

	private AudioClip GetRandomClip()

	{
		// Random range of clips played limited by how many clips(length).
		return clips[Random.Range(0,clips.Length)];	
	}
	
	// Update is called once per frame
	void Update () {
		if (!audioSource.isPlaying)
		{
			audioSource.clip = GetRandomClip();
			audioSource.Play();
		}
		
	}

}
