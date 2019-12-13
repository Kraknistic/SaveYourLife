using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bonus : MonoBehaviour
{
    private bool isDo = false;
    public int scoreToAdd;
    public GameObject Player;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !isDo)
        {
            isDo = true;
            other.GetComponent<Inventory>().addScore(scoreToAdd);
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        isDo = true;
        Player.GetComponent<Inventory>().addScore(scoreToAdd);
        Destroy(this.gameObject);
    }
}
