using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;

    public override void Start()
    {
        Help.text = descriptionAction;
    }
    override public void Object_Picked()
    {
        print(player.GetComponent<Inventory>().HaveStone());
        if (!player.GetComponent<Inventory>().HaveStone())
        {
            player.GetComponent<Inventory>().SetStone();
            Destroy(this.gameObject);
        }
    }
}
