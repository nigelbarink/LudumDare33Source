using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {
	public Vector3 pos;

	void Update () {
		pos = this.transform.position;
		pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		pos += new Vector3 (0,0,35);
		this.transform.position = pos;
	}
}
