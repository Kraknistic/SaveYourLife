using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatform : MonoBehaviour
{
    public GameObject Pilier;
    public float time;
    bool canFall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canFall && time >=0)
        {
            time -= Time.deltaTime;
        }
        if (time <=0)
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
            this.GetComponent<Rigidbody>().useGravity = true;
            Pilier.GetComponent<Rigidbody>().isKinematic = false;
            Pilier.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            canFall = true;
        }
    }
}
