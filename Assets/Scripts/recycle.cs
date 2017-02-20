using UnityEngine;
using System.Collections;

public class recycle : MonoBehaviour {
	public Vector3 pos ;

	public void OnTriggerEnter(Collider other ){
		Debug.Log (" trigger Has been hit" );
		if (other.gameObject.tag == "Player"){
			pos = this.gameObject.transform.position;
			pos += new Vector3 (0f,0f, 170.6f);
			this.gameObject.transform.position = pos;
		}

	}


}
