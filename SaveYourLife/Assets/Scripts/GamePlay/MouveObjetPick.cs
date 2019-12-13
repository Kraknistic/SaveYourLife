using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouveObjetPick : MonoBehaviour
{
    private float dist = 2.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0 && dist >= 2.2f)
        {
            dist -= 0.2f;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") > 0 && dist <= 4f)
        {
            dist += 0.2f;
        }
        this.gameObject.transform.localPosition = new Vector3(0, 0, dist);
    }
}
