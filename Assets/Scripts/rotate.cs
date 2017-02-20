using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	public int speed = 5;

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0,1*speed,0));
	}
}
