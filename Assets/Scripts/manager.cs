using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class manager : MonoBehaviour { 
	/*
	 * level		count
	 * mainscreen	0
	 * maingame		1
	 * shopping		2
	 * work 		3
	 * dinner		4
	 * learning 	UI
*/ 
	public static float time = 0;
	public static float meters = 4;
	public static float feet = 13.12f;
	public static float food = 100;
	public static float dollars = 20;
	public static int potion =0;

	public int damage = 15;


	public bool boost = false;
	public bool salaryboost = false ;
	public static  bool cantdothat = false;

	public static bool dinner = false ;
	public static bool shopped = false ;
	public static bool shoppedF = false ;
	public static bool worked = false ;
	public static bool workedF = false ;


	private static  bool created = false; 
	void Awake() {

		if (!created){    
			DontDestroyOnLoad(this.gameObject);
			created = true;
		}else {
			Destroy(this.gameObject);
		}


	}

	public void Update (){
		time += 0.05f;
		upgrades();
		GUIManager g = Camera.main.GetComponent<GUIManager>();
		if (food == 0){
			g.b[1].interactable = false;
			if (meters == 0){
				GUIManager.win = true;
			}
			if (meters == 0 ){
				g.b[0].interactable = false;
			}
		}


	

	}

	public  void upgrades (){
		if (shopped){
			Debug.Log ("you just shopped in the mall!");
			potion ++;
			if (salaryboost){
				potion += 2;
			}
			shopped = false;
		}
		if (shoppedF){
			Debug.Log("You failed To Get food from the mall" );
			potion --;
			shoppedF = false;
		}
		
		if (worked){
			Debug.Log ("you did a great job!");
			dollars += 5;
			if (salaryboost){
				dollars += 7 ;
				worked = false;
			}
			worked = false;
		}
		if (workedF){
			Debug.Log("You FAIL" );
			dollars --;
			Time.timeScale = 1;
			workedF = false;
		}
		if (dinner){
			Debug.Log ("HMM my belly is round");
			Application.LoadLevel(0);
			if ( salaryboost){
				food -= 100 ;
				dinner = false;
			}
			food -= 50 ;
			dinner = false;
		}
	}
	public void  buyboost (int item){
		switch (item){
			// earnings boost 
		case 1:
			if (boost){
				if (dollars >= 12.5 ){
				dollars -= 12.50f;
				salaryboost = true ;
					break;
				}
				cantdothat = true;
				break;
			}
			if (dollars >= 25){
			dollars -= 25f;
				salaryboost = true;
			break;
			}
			cantdothat = true ;
			break;
			//damage boost 
		case 2:
			if (boost){
				if (dollars >= 30 ){
				dollars -= 30f;
				damage *= 2;
					break;}
				cantdothat = true ;
				break;
			}
			if (dollars >= 50){
			dollars -= 50f;
				damage *= 2;
			break;
			}
			cantdothat = true ;
			break;
			//cheap boost
		case 3:
			if (boost){
				cantdothat = true ;
				break;
			}
			if (dollars >= 60){
			dollars -= 60f;
			boost = true;
			break;
			}
			cantdothat = true;
			break;
			// cheat
		case 4:
			if (boost){
			if (dollars >= 80){
				dollars -= 80;
				GUIManager.win = true;
					break;
			}
				cantdothat = true;
				break;
			}
			if (dollars >= 100){
				dollars -= 100f;
				GUIManager.win = true;
				break;
			}
			cantdothat = true ;
			break;
		}
	}




}
