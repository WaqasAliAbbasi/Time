using UnityEngine;
using System.Collections;

public class stopAudio : MonoBehaviour {

	public AudioSource audioSource;
	public GameObject info;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (audioSource.isPlaying)
			StartCoroutine(FadeOut(3f));
		info.SetActive (false);
	}

	IEnumerator FadeOut (float FadeTime) {
		//yield return new WaitForSeconds (17);
		float startVolume = audioSource.volume;

		while (audioSource.volume > 0) {
			audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

			yield return null;
		}

		audioSource.Stop ();
		audioSource.volume = startVolume;
	}
}
