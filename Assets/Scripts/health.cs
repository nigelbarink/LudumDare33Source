using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	public float life = 100;

	public void Dodamage (){

		Axecontroll c = Camera.main.GetComponent<Axecontroll>();
		if(!c )
			Debug.Log("no axecontroll !!!");
		life -= c.damage ;
		if (life <= 0){
			die();
		}
	} 

	public void die (){
	Axecontroll a =	Camera.main.GetComponent<Axecontroll>();
			a.pigs.Remove(this.gameObject);
		GameObject.Destroy(this.gameObject);
		if (a.pigs.Count <= 0){
			Time.timeScale = 0;
			a.timer = a.time;
			manager.worked = true;
			Application.LoadLevel(1);
		}

	}
}
