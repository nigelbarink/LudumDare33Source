using UnityEngine;
using System.Collections;

public class ApplicationHelper : MonoBehaviour {

	public void exitapp (){
		Application.Quit();
	}
	public void retry(){
		manager.time =0;
		manager.meters = 4;
		manager.feet = 13.12f;
		manager.potion = 0;
		manager.dollars = 20;
		manager.food = 100;
		GUIManager.win = false;
		Application.LoadLevel(Application.loadedLevel);
	}
	public void loaddinner(){
		Application.LoadLevel(3);
	}
	
	public void loadshopping(){
		Application.LoadLevel(2);
	}
	public void loadwork(){
		Application.LoadLevel(4);
	}
	public void loadmain (){
		Application.LoadLevel(1);
	}
	public void loadmenu (){
		Application.LoadLevel(0);
	}
	public void drinkpotion(){
		if (manager.potion != 0){
			manager.meters -= 0.8f  ;
			manager.feet -= 2.62f ;
			manager.potion --;
		}
	}
	public void drinkpotions(){
		if (manager.potion != 0){
			manager.meters -= 0.8f * manager.potion ;
			manager.feet -= 2.62f * manager.potion;
			manager.potion -= manager.potion ;
		}
	}
	public void StartGame(){
		Time.timeScale =1;
	}
}
