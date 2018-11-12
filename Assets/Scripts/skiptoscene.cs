using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class skiptoscene : MonoBehaviour {

	public float fadeduration = 3f;
	public AudioSource audioSource;
	public string scene;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void skip () {
		StartCoroutine(waitBeforeFinish(fadeduration));
	}

	IEnumerator waitBeforeFinish (float time) {
		StartCoroutine(FadeOut(time));
		yield return new WaitForSeconds (time);
		SceneManager.LoadScene (scene);	
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
