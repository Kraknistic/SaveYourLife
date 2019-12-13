using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public bool CanOpen;
    float Rotation;
    public AudioSource sound;
    int y = 0;
    public int maxOpen;
    private bool isDo = false;
    private float coef;
    void Start()
    {
        CanOpen = false;
        if (maxOpen > 0)
            coef = 1;
        else
            coef = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanOpen && Mathf.Abs(ConvertAngle(transform.localEulerAngles.y)) < Mathf.Abs(maxOpen) && Mathf.Abs(maxOpen) < 180)
        {
            transform.Rotate(new Vector3(0, 100 * coef, 0) * Time.deltaTime);
            if (!isDo)
            {
                sound.Play();
                isDo = true;
            }
        }
    }

    float ConvertAngle(float angle)
    {
        if (angle > 180)
            angle = 360 - angle;
        return angle;
    }
}
