using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;

    public override void Start()
    {
        Help.text = descriptionAction;
    }

    override public void Object_Picked()
    {
        print(player.GetComponent<Inventory>().HaveStick());
        if (!player.GetComponent<Inventory>().HaveStick())
        {
            player.GetComponent<Inventory>().SetStick();
            Destroy(this.gameObject);
            base.Declencher_Etape_Suivante_Du_Scenario();
        }
    }
}
