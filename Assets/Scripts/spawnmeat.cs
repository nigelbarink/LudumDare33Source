using UnityEngine;
using System.Collections;

public class spawnmeat : MonoBehaviour {
	public float tim  ; 
	public float tim_buf ;
	public GameObject[] food;
	void Start(){
		tim_buf = Random.Range(30,130);
		tim = tim_buf;
	}
   void Update () {
		tim--;
		if(tim <= 0){
			int num = Random.Range(0,food.Length -1 );
			GameObject.Instantiate(food[num],this.transform.position, Quaternion.identity );
			tim = tim_buf;
		}
	}
}
