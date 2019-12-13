using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INTERACTION_COLLISION_WITH_PLAYER : Action_Scenario_Etape
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Declencher_Etape_Suivante_Du_Scenario();
        }
    }


    override public void Update() { }
}
