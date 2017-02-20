using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class destroyer2 : MonoBehaviour {
	public int points = 0;
	public Text t ;
	public bool destroyer = false;
	 public void OnTriggerEnter2D (Collider2D coll){
		if(coll.gameObject.tag == "Mouth" ){
			if(!destroyer){
			points ++;
			GameObject.Destroy(coll.gameObject);
		}
			GameObject.Destroy(coll.gameObject);
	
		}
	}
	public void Update (){
		if (t){
		t.text = "Points: " + points;
	}
	if ( points >= 100 ){
			points = 0;
			manager.dinner = true ;
	}

}
}
