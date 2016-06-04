using UnityEngine;
using System.Collections;

public class primaryGoalTrigger : MonoBehaviour
{
    public float possibleScoreTimeoutCfg = 2.0f;
    public uint rewardValue = 2; //How many points to give the player for hitting this target.

    bool possibleScore = false;
    float possibleScoreTimeout = 0.0f;
    


    void OnTriggerEnter(Collider collider) {
        print("Top of Basketball hoop hit");
        possibleScore = true;
        possibleScoreTimeout = possibleScoreTimeoutCfg;
    }

    void Update() {
        if (possibleScore && possibleScoreTimeout > 0) {
            possibleScoreTimeout -= Time.deltaTime;
            secondaryGoalTrigger sec = GetComponentInChildren<secondaryGoalTrigger>();
            if (sec.ExpectCollider()) {
                sec.ResetCollider();
                possibleScore = false;
                Scorekeeper scoreKeep = FindObjectOfType<Scorekeeper>();
                scoreKeep.IncrementScore(rewardValue);
            }
        } 
    }
}
