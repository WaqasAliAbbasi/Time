using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Synchronisation : MonoBehaviour {

	private float syncpercent;
	public TextMesh sync;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void handlesync (AudioSource audio) {
		syncpercent = Mathf.Round(ShowInfo.progress * 12.5f * 100f)/100f ;
		sync.text= syncpercent + "%";
		if (ShowInfo.progress == 8) {
			StartCoroutine(waitBeforeFinish(audio.clip.length));
		}


	}

	IEnumerator waitBeforeFinish (float time) {
		yield return new WaitForSeconds (time);
		SceneManager.LoadScene ("End");	
	}
}
