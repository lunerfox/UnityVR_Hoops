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
        /*
        if (Input.GetKeyDown(KeyCode.A)) {
            //Creates a new ball.
            instance = Instantiate(ballPrefab);
            instance_RB = instance.GetComponent<Rigidbody>();
            //Starting position of the ball.
            Vector3 startPos = new Vector3(0, 2, 2);
            
            instance_RB.useGravity = false;
        }
        */

        if (Input.GetKeyDown(KeyCode.Space)){
            Camera camera = GetComponentInChildren<Camera>();
            //Creates a new ball.
            instance = Instantiate(ballPrefab);
            instance_RB = instance.GetComponent<Rigidbody>();
            //Starting position of the ball.
            Vector3 startPos = new Vector3(0, 2, 2);
            instance_RB.transform.position = transform.position + startPos;
            //We use the global rotations here because from the camera's perspective, the only rotation
            //thats changing is in the y axis. The body itself handles the x axis rotation. If we use
            //Local Rotation, then the object will only report y direction changes.
            instance_RB.velocity = camera.transform.rotation * Vector3.forward * velocity_scale;
            instance_RB.useGravity = true;
        }
    }
}
