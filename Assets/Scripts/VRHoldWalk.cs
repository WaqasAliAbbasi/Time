using UnityEngine;
using System.Collections;

public class VRHoldWalk : MonoBehaviour {

	public Transform vrCamera;

	public float speed = 2.0f;

	public bool moveForward;

	private bool playSound = true;

	public AudioSource footstep;

	private CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.touchCount > 0) {
			var touch = Input.GetTouch(0);
			
			TouchPhase phase = touch.phase;
			switch(phase) {
			case TouchPhase.Began:
				/*if ( touch.tapCount >= 2 ) {
					Application.LoadLevel(NextSceneIndex);
				}*/
				break;
			case TouchPhase.Moved:
			case TouchPhase.Stationary:
				moveForward = true;
				if (playSound) {
					footstep.Play ();
					playSound = false;
				}
				break;
			case TouchPhase.Ended:
				moveForward = false;
				footstep.Stop ();
				playSound = true;
				break;
			}
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			moveForward = true;
			footstep.Play ();
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			footstep.Stop ();
			moveForward = false;
		}

		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit();
	
		if (moveForward) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed);
	}
}

}
