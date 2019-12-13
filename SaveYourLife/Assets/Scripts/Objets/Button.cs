using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : INTERACTION_CLICK_AND_PICK
{
    public GameObject m_Door1;
    public GameObject m_Door2;
    public bool DoubleDoor;
    // cette fonction est définie ici à minima et peut être suffisante
    // ou peu nécessiter d'être à nouveau redéfinie ("overrided") dans la classe fille
    // possibilité de compléter ce code en commencant la méthodes redéfinie par base.Start(); ....
    override public void Start()
    {
        base.Start();
        Help.text = descriptionAction;
    }


    override public void Object_Picked()
    {
        m_Door1.gameObject.GetComponent<Door>().CanOpen = true;
        if (DoubleDoor)
        {
            m_Door2.gameObject.GetComponent<Door>().CanOpen = true;
        }
        base.Declencher_Etape_Suivante_Du_Scenario();
    }
}
