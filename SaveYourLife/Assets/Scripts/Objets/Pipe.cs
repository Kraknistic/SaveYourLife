using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boutton;
    public bool Pipe_Bleu;
    public bool Pipe_Rouge;
    public bool Pipe_Vert;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere_Bleu")
            if (Pipe_Bleu)
                boutton.GetComponent<Pipes>().Pipe_Blue = true;
            else
                boutton.GetComponent<Pipes>().Pipe_Blue = false;

        if (other.name == "Sphere_Rouge" && Pipe_Rouge)
            if (Pipe_Rouge)
                boutton.GetComponent<Pipes>().Pipe_Red = true;
            else
                boutton.GetComponent<Pipes>().Pipe_Red = false;

        if (other.name == "Sphere_Verte" && Pipe_Vert)
            if (Pipe_Vert)
                boutton.GetComponent<Pipes>().Pipe_Green = true;
            else
                boutton.GetComponent<Pipes>().Pipe_Green = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Sphere_Bleu")
            if (Pipe_Bleu)
                boutton.GetComponent<Pipes>().Pipe_Blue = false;

        if (other.name == "Sphere_Rouge" && Pipe_Rouge)
            if (Pipe_Rouge)
                boutton.GetComponent<Pipes>().Pipe_Red = false;

        if (other.name == "Sphere_Verte" && Pipe_Vert)
            if (Pipe_Vert)
                boutton.GetComponent<Pipes>().Pipe_Green = false;
    }
}
