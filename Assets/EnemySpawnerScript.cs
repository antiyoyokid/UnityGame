using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {
    public GameObject enemy;
    float randX;
    Vector3 wheretospawn;
    public double spawnRate = 1.5f;
    double nextSpawn = 0.0f;
    private const double coef = 0.04f;
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        spawnRate -= coef * (Time.deltaTime);
        if (spawnRate < 0.05)
        {
            spawnRate = 0.05;
        }

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
           randX = Random.Range(-8.4f, 8.4f);
            wheretospawn = new Vector3(randX, 6, 0);
            Instantiate(enemy, wheretospawn, Quaternion.identity);
                }
	}

   
}
