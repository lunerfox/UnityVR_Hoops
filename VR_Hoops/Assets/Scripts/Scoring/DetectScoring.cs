using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {

    public uint rewardValue = 2; //How many points to give the player for hitting this target.

	// Use this for initialization
	void Start () {
        print("Target Found");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        print("Object has Collided.");
        Scorekeeper scoreKeep = FindObjectOfType<Scorekeeper>();
        scoreKeep.IncrementScore(rewardValue);
    }
}
