using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawTop : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;
    public MeshRenderer Object;

    private void Start()
    {
        Object.enabled = false;
    }
    private void OnMouseEnter()
    {
        if (player.GetComponent<Inventory>().HaveStraw())
        {
            Object.enabled = true;
            player.GetComponent<Inventory>().Straw.SetActive(false);
            player.GetComponent<Inventory>().SetStrawTop();
            //base.Declencher_Etape_Suivante_Du_Scenario();
        }
    }
}
