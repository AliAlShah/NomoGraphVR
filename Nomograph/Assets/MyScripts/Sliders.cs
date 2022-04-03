using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliders : MonoBehaviour
{

    public GameObject xSlider;
    public GameObject ySlider;

    private Rigidbody xRB;
    private Rigidbody yRB;

    void Start()
    {
        xRB = xSlider.GetComponent<Rigidbody>();
        yRB = ySlider.GetComponent<Rigidbody>();
    }

    public void freezeSliders()
    {
        xRB.velocity = Vector3.zero;
        yRB.velocity = Vector3.zero;
    }
}
