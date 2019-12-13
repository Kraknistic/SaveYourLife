using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levier : MonoBehaviour
{
    private float posBas = -40;
    private float posMid = 0;
    private float posHaut = 40;
    private float posActu;
    public int NumeroDuLevier = 0;
    public int ValeurL1, ValeurL2, ValeurL3, ValeurL4;
    private int Total;

    private void Start()
    {
        ValeurL1 = 2;
        ValeurL2 = 20;
        ValeurL3 = 200;
        ValeurL4 = 2000;
    }
    private void OnMouseDown()
    {
        posActu = Mathf.Round(this.GetComponent<Transform>().localEulerAngles.x); //this.GetComponent<Transform>().rotation.x;
        print(posActu);
        if(posActu == posMid)
        {
            this.GetComponent<Transform>().Rotate(posBas,0,0);
            if (NumeroDuLevier == 1) { ValeurL1 = 3; }
            if (NumeroDuLevier == 2) { ValeurL2 = 30; }
            if (NumeroDuLevier == 3) { ValeurL3 = 300; }
            if (NumeroDuLevier == 4) { ValeurL4 = 3000; }
        }
        else if (posActu == posBas + 360)
        {
            this.GetComponent<Transform>().Rotate(80, 0, 0);
            if (NumeroDuLevier == 1) { ValeurL1 = 1; }
            if (NumeroDuLevier == 2) { ValeurL2 = 10; }
            if (NumeroDuLevier == 3) { ValeurL3 = 100; }
            if (NumeroDuLevier == 4) { ValeurL4 = 1000; }
        }
        else if (posActu == posHaut)
        {
            this.GetComponent<Transform>().Rotate(-40, 0, 0);
            if (NumeroDuLevier == 1) { ValeurL1 = 2; }
            if (NumeroDuLevier == 2) { ValeurL2 = 20; }
            if (NumeroDuLevier == 3) { ValeurL3 = 200; }
            if (NumeroDuLevier == 4) { ValeurL4 = 2000; }
        }
    }
}
