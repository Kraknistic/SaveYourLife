using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private bool isDo = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !isDo)
        {
            isDo = true;
            other.GetComponent<Inventory>().addStar();
            Destroy(this.gameObject);
        }
    }
}