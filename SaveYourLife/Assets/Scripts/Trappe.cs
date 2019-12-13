using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trappe : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;
    public GameObject destroyedVersion;
    public override void Start()
    {
        Help.text = descriptionAction;
    }
    override public void Object_Picked()
    {
        if (player.GetComponent<Inventory>().HaveAxe())
        {
            player.GetComponent<Inventory>().Axe.SetActive(false);
            player.GetComponent<Inventory>().SetCanTakeTorch();
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            base.Declencher_Etape_Suivante_Du_Scenario();
            Destroy(this.gameObject);
        }
    }
}
