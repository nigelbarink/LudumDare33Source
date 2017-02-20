using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour {
	public Vector3 pos ;
	public float move_buf = 9f;
	public float move = 0;
	void Update () {
		move = move_buf  * Input.GetAxis("Horizontal");
		pos = this.transform.position;
		pos += new Vector3 (move ,0,0);
		this.transform.position = pos ;
	}
}
