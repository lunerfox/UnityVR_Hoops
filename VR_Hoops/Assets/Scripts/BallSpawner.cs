using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;
    const float velocity_scale = 5.0f;

	// Use this for initialization
	void Start () {
        print("Ball Spawner Active");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            //Creates a new ball.
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody instance_RB = instance.GetComponent<Rigidbody>();
            instance_RB.velocity = velocity_scale*Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Creates a new ball.
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody instance_RB = instance.GetComponent<Rigidbody>();
            instance_RB.velocity = velocity_scale * Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Creates a new ball.
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody instance_RB = instance.GetComponent<Rigidbody>();
            instance_RB.velocity = velocity_scale * Vector3.forward;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Creates a new ball.
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody instance_RB = instance.GetComponent<Rigidbody>();
            instance_RB.velocity = velocity_scale * Vector3.back;
        }
    }
}
