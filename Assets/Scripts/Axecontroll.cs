using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Axecontroll : MonoBehaviour {
	public RaycastHit hitinfo ;
	public Ray ray ;
	public Vector3 pos;
	public int damage = 50;
	public GameObject axe;
	public  List<GameObject> pigs;
	public float time = 7000;
	public float timer = 7000;
	public Text clock;
	void Start(){

		GameObject[] p = GameObject.FindGameObjectsWithTag("Enemy") ;
		if (p == null){
			Debug.Log("cant get the pigs !");
		}
		foreach ( GameObject i in p ){
			pigs.Add(i);
		}
	}
	void Update () {
		timer --;
		clock.text = "you have " + timer +" seconds";
		if (timer == 0 ){
			Time.timeScale = 0;
			timer = time;
			manager.workedF = true ;
			Application.LoadLevel(1);
		}
		if(Input.GetMouseButtonDown(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Physics.Raycast (ray,out hitinfo , Mathf.Infinity); 
			GameObject target = hitinfo.collider.gameObject;
			if (target == null){
			Debug.Log ("");
			}
			if (target.tag == "Enemy" ){
				Debug.Log("whack!");
				health h = target.GetComponent<health>();
				if (!h){
					Debug.Log ("");

				}
				h.Dodamage();

			}
		}

			
				}
}
