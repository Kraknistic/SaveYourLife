using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongButton : INTERACTION_CLICK_AND_PICK
{
    public GameObject plaque;

    override public void Start()
    {
        base.Start();
        Help.text = descriptionAction;
    }

    override public void Object_Picked()
    {
        Destroy(plaque);
    }
}