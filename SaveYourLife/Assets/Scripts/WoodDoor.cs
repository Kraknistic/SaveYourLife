using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodDoor : INTERACTION_CLICK_AND_PICK
{
    // Start is called before the first frame update
    public bool CanOpen;
    float Rotation;
    int y = 0;
    public int maxOpen;
    private bool isDo = false;
    public GameObject L1, L2, L3, L4;
    public int Solution;
    private int Total;
    public override void Start()
    {
        Help.text = descriptionAction;
        CanOpen = false;
        if (Solution == 0)  
            Solution = Random.Range(1, 4) * 1000 + Random.Range(1, 4) * 100 + Random.Range(1, 4) * 10 + Random.Range(1, 4);
    }

    public override void Update()
    {
        Total = L1.GetComponent<Levier>().ValeurL1 + L2.GetComponent<Levier>().ValeurL2 + L3.GetComponent<Levier>().ValeurL3 + L4.GetComponent<Levier>().ValeurL4;
        print("Valeur Solution: " + Solution);
        print("Valeur Levier: " + Total);
        if (CanOpen)
        {
            if (maxOpen < 180 && maxOpen > 0)
            {
                if (transform.localEulerAngles.y < maxOpen)
                    transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
                else
                    base.Declencher_Etape_Suivante_Du_Scenario();
            }
            if (maxOpen >= 180)
            {
                if (transform.localEulerAngles.y <= 45 && transform.localEulerAngles.y > 0 || transform.localEulerAngles.y > maxOpen)
                    transform.Rotate(new Vector3(0, -100, 0) * Time.deltaTime);
                else
                    base.Declencher_Etape_Suivante_Du_Scenario();
            }
        }
    }

    public override void Object_Picked()
    {
        if (Total == Solution)
        {
            this.CanOpen = true;
            //base.Declencher_Etape_Suivante_Du_Scenario();
        }
    }
}
