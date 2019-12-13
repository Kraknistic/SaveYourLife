using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WIN : INTERACTION_CLICK_AND_PICK
{
    public GameObject YouEscaped;
    public GameObject CameraTrain;
    public GameObject CameraPlayer;
    public float timer = 3;
    private bool youwin = false;
    override public void Object_Picked()
    {
        YouEscaped.SetActive(true);
        CameraTrain.SetActive(true);
        youwin = true;
    }
    public override void Update()
    {
        if (youwin)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 4;
                youwin = false;
                SceneManager.LoadScene("Scene_YouWin");
            }
        }
    }
}
