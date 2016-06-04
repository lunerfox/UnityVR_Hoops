//Score Handler: Keeps track of the score in the game.

using UnityEngine;
using System.Collections;

public class Scorekeeper : MonoBehaviour {

    uint score;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void IncrementScore(uint reward) { 
        score = score + reward;
        print("Ball hit target! Your score is now " + score);
    }
}
