using UnityEngine;
using System.Collections;

public class bombSpawn : MonoBehaviour {

	public GameObject bomb;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 5f;
	float nextSpawn = 0.0f;
	[SerializeField]
	public float spawnSpeed = 5f;




	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range(-7f,7f);
			whereToSpawn = new Vector2(randX,transform.position.y + spawnSpeed*Time.deltaTime);
			Instantiate(bomb,whereToSpawn,Quaternion.identity);
		}
	}



}
