using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : INTERACTION_CLICK_AND_PICK
{
    public GameObject Player;

    public override void Object_Picked()
    {
        if (!Player.GetComponent<Inventory>().HaveKey())
        {
            Player.GetComponent<Inventory>().SetKey();
            Destroy(this.gameObject);
        }
            

    }
}
