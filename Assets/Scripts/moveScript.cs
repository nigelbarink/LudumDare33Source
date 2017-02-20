using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {
	public int timer =0;
	public Vector3 pos ;
	public int speed = 6;




	void Update () {
	
		pos = this.transform.position;
		pos += new Vector3 (
			0,
			0,speed * Time.deltaTime);
		this.transform.position = pos ;
	}
}
