using UnityEngine;
using System.Collections;

public class secondaryGoalTrigger : MonoBehaviour {

    bool secondaryTriggered = false;

    void OnTriggerEnter(Collider collider)
    {
        print("Bottom of Basketball hoop hit");
        secondaryTriggered = true;
    }

    public bool ExpectCollider()
    {
        return secondaryTriggered;
    }

    public void ResetCollider()
    {
        secondaryTriggered = false;
    }

}
