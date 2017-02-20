using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public float timer; 
	public int max = 100;
	public int min = 1;
	public  GameObject[] prefabs;  
 
	// Update is called once per frame
	void Update () {
		timer --;

      if (timer == 0 ){
			timer += 420;
			int num = Random.Range(0,prefabs.Length -1);
			GameObject.Instantiate(prefabs[num], this.transform.position + new Vector3 (0,0.5f,0), Quaternion.identity);
		}
		}

		}

