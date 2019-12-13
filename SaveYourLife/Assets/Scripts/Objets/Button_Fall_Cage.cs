using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Fall_Cage : INTERACTION_CLICK_AND_PICK
{
    // Start is called before the first frame update
    public GameObject Cage;
    public GameObject Destroy_Objet;
    public GameObject Player;
    public int nbStars = 6;

    override public void Start()
    {
        Help.text = descriptionAction;
    }

    // Update is called once per frame
    override public void Object_Picked()
    {
        if (Player.GetComponent<Inventory>() != null)
        {
            if (Player.GetComponent<Inventory>().nbStars() == nbStars)
            {
                Cage.GetComponent<Rigidbody>().isKinematic = false;
                Cage.GetComponent<Rigidbody>().useGravity = true;
                Destroy(Destroy_Objet);
                base.Declencher_Etape_Suivante_Du_Scenario();
            }
        }
    }
}
