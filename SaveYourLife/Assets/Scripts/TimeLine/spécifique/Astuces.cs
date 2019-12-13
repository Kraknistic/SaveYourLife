using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astuces : MonoBehaviour
{
    public GameObject Scenario;
    public Text Astuce_UI;
    public List<float> listTimer;
    int etapeActuelle = 0;
    public float Astuce_Time;
    int nbEtape;
    bool isDo = false;

    private void Start()
    {
        nbEtape = _MGR_ScenarioManager.Instance.GetComponent<_MGR_ScenarioManager>().p_etapes.Count;
    }

    private void Update()
    {
        if (etapeActuelle <= nbEtape)
        {
            Astuce_Time -= Time.deltaTime;

            if (Astuce_Time <= 0)
            {
                Astuce_UI.enabled = true;
                isDo = true;
            }
            if (_MGR_ScenarioManager.Instance.GetComponent<_MGR_ScenarioManager>().p_num_etapeEnCours == etapeActuelle)
            {
                print("ETAPE ACTUELLE: " + etapeActuelle);
                Astuce_UI.enabled = false;
                Astuce_Time = listTimer[etapeActuelle];
                etapeActuelle++;
            }
        }
    }
}
