using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
             GetComponent<MeshRenderer>().material.color = Color.green;
        }

        Debug.Log("Collided");
    }
}
