using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastStep : INTERACTION_CLICK_AND_PICK
{
    private bool bStraw;
    public GameObject Straw;
    public GameObject player;
    public GameObject Fire;
    public Camera CameraPlayer;
    public Camera CameraEnd;
    private bool bFire;
    public float timer = 8;
    private bool youwin = false;
    public override void Start()
    {
        Help.text = descriptionAction;
    }
    public override void Object_Picked()
    {
        if (player.GetComponent<Inventory>().HaveStraw())
        {
            player.GetComponent<Inventory>().SetStraw(false);
            Straw.gameObject.SetActive(true);
            bFire = true;
        }
        else if(bFire && player.GetComponent<Inventory>().HaveTorch())
        {
            Fire.gameObject.SetActive(true);
            //CameraPlayer.gameObject.SetActive(false);
            CameraEnd.gameObject.SetActive(true);
            youwin = true;
        }
    }
    public override void Update()
    {
        if (youwin)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 8;
                youwin = false;
                SceneManager.LoadScene("Scene_YouWin");
            }
        }
    }
}
