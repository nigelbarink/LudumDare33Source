using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GUIManager : MonoBehaviour {
	public Text timer ;
	public Text decrpot_text;
	public Text Dollars_text;
	public Text length ;
	public Text food ;
	public  Button[] b;
	public GameObject screen ;
	public GameObject cant ;
	public static bool win = false;
	void Update () {
		if (manager.cantdothat){
			//cant.SetActive(true);
		}
		timer.text = "Time: " + (int)manager.time + " seconds";
		length.text = "Length: " + manager.meters + " meter/ " +  manager.feet + " feet";   
		food.text = "food bar:  " + manager.food + " kilograms";
		decrpot_text.text = "" + manager.potion;
		Dollars_text.text = "" + manager.dollars;
		if (win){
			screen.SetActive(true);
		}

	}

}
