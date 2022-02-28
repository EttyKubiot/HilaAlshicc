using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
//#if UNITY_EDITOR
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider != null)
                {
                    Color newColor = Color.blue;
                    hit.collider.GetComponent<MeshRenderer>().material.color = newColor;
                }
            }
        }
    }
}
