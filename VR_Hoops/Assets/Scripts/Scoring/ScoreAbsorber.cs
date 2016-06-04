using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

    public uint score;

	// Use this for initialization
	void Start () {
        score = 0;
        Scorekeeper oldKeeper = FindObjectOfType<Scorekeeper>();
        if (oldKeeper) {
            score = oldKeeper.getScore();
            Destroy(oldKeeper.gameObject);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public uint getScore()
    {
        return score;
    }
}
