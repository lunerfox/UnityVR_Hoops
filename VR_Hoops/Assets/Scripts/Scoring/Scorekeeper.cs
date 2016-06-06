//Score Handler: Keeps track of the score in the game.

using UnityEngine;
using System.Collections;

public class Scorekeeper : MonoBehaviour {

    uint score;

    void Awake () {
        DontDestroyOnLoad(this);
    }

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
        //Play the associated audio when a scoring occurs.
        GetComponent<AudioSource>().Play();
    }

    public uint getScore() {
        return score;
    }

    public void resetScore() {
        score = 0;
    }
}
