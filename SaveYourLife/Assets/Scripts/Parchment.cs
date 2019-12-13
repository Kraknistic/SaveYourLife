using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Parchment : MonoBehaviour
{
    public GameObject WoodDoor;
    private int Solution;
    public int NumeroDuParchemin;
    public TextMeshPro NumeroDuLevier;
    public TextMeshPro Position;
    private int Temp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Solution = WoodDoor.GetComponent<WoodDoor>().Solution;
        if (NumeroDuParchemin == 1)
        {
            NumeroDuLevier.text = "1";
            Temp = Solution / 1000;
            if (Temp == 1)
                Position.text = "↑";
            if (Temp == 2)
                Position.text = "-";
            if (Temp == 3)
                Position.text = "↓";
            //Position.text = Temp.ToString();
        }
        if (NumeroDuParchemin == 2)
        {
            NumeroDuLevier.text = "2";
            Temp = Solution / 100 - Solution / 1000 * 10;
            if (Temp == 1)
                Position.text = "↑";
            if (Temp == 2)
                Position.text = "-";
            if (Temp == 3)
                Position.text = "↓";
            //Position.text = Temp.ToString();
        }
        if (NumeroDuParchemin == 3)
        {
            NumeroDuLevier.text = "3";
            Temp = Solution / 10 - Solution / 100 * 10;
            if (Temp == 1)
                Position.text = "↑";
            if (Temp == 2)
                Position.text = "-";
            if (Temp == 3)
                Position.text = "↓";
            //Position.text = Temp.ToString();
        }
        if (NumeroDuParchemin == 4)
        {
            NumeroDuLevier.text = "4";
            Temp = Solution - Solution / 10 * 10;
            if (Temp == 1)
                Position.text = "↑";
            if (Temp == 2)
                Position.text = "-";
            if (Temp == 3)
                Position.text = "↓";
            //Position.text = Temp.ToString();
        }
    }
}
