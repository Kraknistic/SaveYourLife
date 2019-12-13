using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;

    public override void Start()
    {
        Help.text = descriptionAction;
    }

    override public void Object_Picked()
    {
        print(player.GetComponent<Inventory>().HaveRope());
        if (!player.GetComponent<Inventory>().HaveRope())
        {
            player.GetComponent<Inventory>().SetRope();
            Destroy(this.gameObject);
        }
    }
}
