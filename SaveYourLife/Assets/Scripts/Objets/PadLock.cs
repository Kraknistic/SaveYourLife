using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadLock : INTERACTION_CLICK_AND_PICK
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject m_Door;
    public Text Info;

    public override void Start()
    {
        Help.text = descriptionAction;
    }

    override public void Object_Picked()
    {
        if (player.GetComponent<Inventory>().HaveKey())
        {
            Info.enabled = false;
            m_Door.gameObject.GetComponent<Door>().CanOpen = true;
            base.Declencher_Etape_Suivante_Du_Scenario();
            Destroy(this.gameObject);
        }
    }
}
