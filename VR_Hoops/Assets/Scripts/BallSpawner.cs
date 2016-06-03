using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
        print("Ball Spawner Active");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //Creates a new ball.
            GameObject instance = Instantiate(ballPrefab);
        }
	}
}
