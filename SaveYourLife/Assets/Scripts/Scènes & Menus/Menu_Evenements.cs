using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Menu_Evenements : MonoBehaviour {
    private void Update()
    {
        if (Cursor.visible == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void PressPlay() {
        _MGR_SceneManager.Instance.LoadScene("Scene_Play");
    }
    public void PressQuit() {
        CommonDevTools.QUIT_APP("! fin demandée de l'application!");
    }

}
