using UnityEngine;
using System.Collections;

public class remover : MonoBehaviour {

	public void OnTriggerEnter(Collider other ){
		if (other.gameObject.tag == "Respawn"){
			GameObject.Destroy( other.gameObject);
		}
	

	}

}
