using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class Echelle : MonoBehaviour
{
    public bool Monte = false;
    public float vitesse = 8f;
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        if (Monte)
        {
            Player.transform.Translate(Vector3.up * vitesse * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Monte = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Monte = false;
        }
    }
}