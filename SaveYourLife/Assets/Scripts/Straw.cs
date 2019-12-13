using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straw : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;

    public override void Start()
    {
        Help.text = descriptionAction;
    }

    override public void Object_Picked()
    {
        print(player.GetComponent<Inventory>().HaveStraw());
        if (!player.GetComponent<Inventory>().HaveStraw())
        {
            player.GetComponent<Inventory>().SetStraw(true);
            Destroy(this.gameObject);
        }
    }
}
