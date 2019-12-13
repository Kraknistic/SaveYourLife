using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : INTERACTION_CLICK_AND_PICK
{
    public GameObject player;
    public ParticleSystem particle;

    override public void Start()
    {
        Help.text = descriptionAction;
    }

    override public void Object_Picked()
    {
        print("MON PLAYER INFO 1/ HaveTorch: " + player.GetComponent<Inventory>().HaveTorch() + " haveStrawTop " + player.GetComponent<Inventory>().HaveStrawTop());
        if (player.GetComponent<Inventory>().HaveTorch() && player.GetComponent<Inventory>().HaveStrawTop())
        {
            //particle.Play();
            particle.gameObject.SetActive(true);
            player.GetComponent<Inventory>().Torch.SetActive(false);
            //SceneManager.LoadScene("Scene_YouWin");
            //base.Declencher_Etape_Suivante_Du_Scenario();
            print("MON PLAYER INFO 2/ HaveTorch: " + player.GetComponent<Inventory>().HaveTorch() + " haveStrawTop " + player.GetComponent<Inventory>().HaveStrawTop());
        }
    }
}
