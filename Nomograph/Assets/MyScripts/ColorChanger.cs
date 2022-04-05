using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public LineRenderer line;

    private Transform pos1;
    private Transform pos2;
    private LineRenderer selectedRenderer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            pos1 = GameObject.FindGameObjectWithTag("xslider").transform;
            pos2 = GameObject.FindGameObjectWithTag("yslider").transform;

            selectedRenderer = Instantiate(line);

            selectedRenderer.SetPosition(0, pos1.position);
            selectedRenderer.SetPosition(1, pos2.position);

            Debug.Log(pos1.position);
        }

        
    }
}
