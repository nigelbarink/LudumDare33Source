using UnityEngine;
using System.Collections;

public class penalty : MonoBehaviour {
public void OnCollisionEnter(Collision collision ){
		if (collision.gameObject.tag == "Respawn"){
			GameObject.Destroy(collision.gameObject);
			PointsManager.carts ++;
		}
		if (collision.gameObject.tag == "Food"){
			GameObject.Destroy(collision.gameObject);
			PointsManager.eaten += 0.2f;
		}
	}
}
