using UnityEngine;
using System.Collections;

public class BallCollison : MonoBehaviour {

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        print("Ball has Collided.");
        GetComponent<AudioSource>().Play();   
    }
}
