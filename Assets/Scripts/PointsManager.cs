using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public  class PointsManager : MonoBehaviour {
	public static float eaten = 0 ;
	public static float carts = 0;
	public Text t ;
	public Text c ;

	public void Update(){
		c.text = "Max Carts Hit: " + carts + "/3";
		t.text = "eaten " + eaten + "/5";
		if (eaten >= 5 ){
			manager.shopped = true ;
			eaten = 0;
			carts = 0;
			Application.LoadLevel(0);

		}
		if (carts >= 3){
			manager.shoppedF = true ;
			eaten = 0;
			carts = 0;
			Application.LoadLevel(0);
		}
	}

}
