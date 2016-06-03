using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    public GameObject ballPrefab;
    public float velocity_scale = 8.0f;
    Rigidbody instance_RB;
    GameObject instance;

    // Use this for initialization
    void Start () {
        print("Ball Spawner Active");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A)) {
            //Creates a new ball.
            instance = Instantiate(ballPrefab);
            instance_RB = instance.GetComponent<Rigidbody>();
            //Starting position of the ball.
            Vector3 startPos = new Vector3(0, 2, 2);
            instance_RB.transform.position = transform.position + startPos;
            instance_RB.useGravity = false;
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            //This will have to change based on where you're looking.
            instance_RB.velocity = velocity_scale * (Vector3.forward + Vector3.up);
            instance_RB.useGravity = true;
        }
    }
}
