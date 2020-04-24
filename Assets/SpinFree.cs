using UnityEngine;
using System.Collections;

/// <summary>
/// Spin the object at a specified speed
/// </summary>
public class SpinFree : MonoBehaviour {
	[Tooltip("Spin: Yes or No")]
	public bool spin;
	[Tooltip("Spin the parent object instead of the object this script is attached to")]
	public bool spinParent;
	public float speed = 10f;

	[HideInInspector]
	public bool clockwise = true;
	[HideInInspector]
	public float direction = 1f;
	[HideInInspector]
	public float directionChangeSpeed = 2f;

	public int trackvar;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		trackvar = GameObject.Find("SolarSystem").GetComponent<DefaultTrackableEventHandlerSS>().tracked;
	}

	// Update is called once per frame
	void Update() {

		trackvar = GameObject.Find("SolarSystem").GetComponent<DefaultTrackableEventHandlerSS>().tracked;

        if(trackvar==1){

		if (direction < 1f) {
			direction += Time.deltaTime / (directionChangeSpeed / 2);
		}

		if (spin) {
			if (clockwise) {
				if (spinParent)
					transform.parent.transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime);
				else
					transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime);
			} else {
				if (spinParent)
					transform.parent.transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime);
				else
					transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime);
			}
		}
        
	    }
    }
}