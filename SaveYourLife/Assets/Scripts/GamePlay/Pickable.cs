using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public Camera cam;
    public string selectableTag;
    public Material highlightMaterial;
    Material defaultMaterial;
    private Transform _selection;

    // Start is called before the first frame update
    void Start()
    {
        selectableTag = "Pickable";
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRender = _selection.GetComponent<Renderer>();
            selectionRender.material = defaultMaterial;
            _selection = null;
        }

        //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();
        float max_dist = 2.5f;   // max distance of ray cast
        int layer_mask = LayerMask.GetMask("Pickable");   // ou GetMask("L1", "L2", ...); si plusieurs layers

        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));

        if (Physics.Raycast(ray, out hit, max_dist, layer_mask))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (defaultMaterial != highlightMaterial)
                {
                    defaultMaterial = selectionRenderer.material;
                }
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject ObjetSelected = selection.gameObject;
                    if (ObjetSelected.GetComponent<INTERACTION_CLICK_AND_PICK>())
                    {
                        ObjetSelected.GetComponent<INTERACTION_CLICK_AND_PICK>().Object_Picked();
                    }
                    else
                    {
                        if (ObjetSelected.GetComponentInParent<INTERACTION_EnsembleCapsule>())
                        {
                            ObjetSelected.GetComponentInParent<INTERACTION_EnsembleCapsule>().Object_Picked();
                        }
                        ObjetSelected.SetActive(false);
                    }
                }
            }
            _selection = selection;
        }
    }
}
