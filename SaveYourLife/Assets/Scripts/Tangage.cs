using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tangage : MonoBehaviour
    {

    //public GameObject ObjectToMove;
    public float speed =2.0f;
    private bool b;

    //public Transform init;
    public Transform from;
    public Transform to;
    

    private float timeCount = 0.0f;

    private float inclinaison;
    // Start is called before the first frame update
    void Start()
    {
        b = true;
        
        
    }




    // Update is called once per frame
    void Update()
    {



        if (b)
        {

            transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount);
            timeCount = timeCount + Time.deltaTime * speed;
            if (timeCount >= 0.99)
            {
                b = false;
                timeCount = 0.0f;
            }

        }
        else
        {

            transform.rotation = Quaternion.Slerp(to.rotation, from.rotation, timeCount);
            timeCount = timeCount + Time.deltaTime * speed;
            if (timeCount >= 0.99)
            {
                b = true;
                timeCount = 0.0f;
            }

        }
    }
       
}
