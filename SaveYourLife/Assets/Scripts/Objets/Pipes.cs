using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : INTERACTION_CLICK_AND_PICK
{
    // Start is called before the first frame update
    public bool Pipe_Blue = false;
    public bool Pipe_Green = false;
    public bool Pipe_Red = false;

    public GameObject m_Door;
    public GameObject m_Door2;

    public GameObject Sphere_Bleu;
    public GameObject Sphere_Rouge;
    public GameObject Sphere_Vert;
    public Vector3 posBleu;
    public Vector3 posRouge;
    public Vector3 posVert;
    private bool start;
    override public void Start()
    {
        base.Start();
        Help.text = descriptionAction;
    }

    override public void Update()
    {
        if (start)
        {
            start = !start;
        }
    }
    override public void Object_Picked()
    {
        if (Pipe_Blue && Pipe_Green && Pipe_Red)
        {
            m_Door.gameObject.GetComponent<Door>().CanOpen = true;
            m_Door2.gameObject.GetComponent<Door>().CanOpen = true;
            base.Declencher_Etape_Suivante_Du_Scenario();
        }
        else
        {
            Sphere_Bleu.transform.position = posBleu;

            Sphere_Rouge.transform.position = posRouge;

            Sphere_Vert.transform.position = posVert;

            Pipe_Blue = Pipe_Green = Pipe_Red = false;
        }
    }
}
