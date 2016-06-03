using UnityEngine;
using System.Collections;

public class CamRotation : MonoBehaviour {

    Quaternion rotDelta = Quaternion.Euler(0, 1, 0);

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = transform.rotation * rotDelta;
    }
}
