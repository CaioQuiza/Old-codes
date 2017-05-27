using UnityEngine;
using System.Collections;

public class MusicPlaylist : MonoBehaviour {
	
	public AudioClip[] Soundtrack;

	void Start ()
	{
		if (!GetComponent<AudioSource>().playOnAwake)
		{
			GetComponent<AudioSource>().clip = Soundtrack[Random.Range(0,Soundtrack.Length)];
			GetComponent<AudioSource>().Play();
		}
	}
	

	void Update ()
	{
		if (!GetComponent<AudioSource>().isPlaying)
		{
			GetComponent<AudioSource>().clip = Soundtrack[Random.Range(0, Soundtrack.Length)];
			GetComponent<AudioSource>().Play();
		}
	}
}