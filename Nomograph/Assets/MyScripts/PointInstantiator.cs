using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointInstantiator : MonoBehaviour
{
    public GameObject xSlider;
    public GameObject ySlider;
    public GameObject point;

    private GameObject spawnedPoint;

    private Vector3 xPos;
    private Vector3 yPos;
    private Vector3 pointPos;

    private float xPoint;
    private float yPoint;


    void Start()
    {
        Invoke("InstantiatePoint", 1f);
    }

    public void InstantiatePoint()
    {

        xPos = xSlider.transform.position;
        yPos = ySlider.transform.position;

        xPoint = xPos.y;
        yPoint = yPos.y;

        

        pointPos = new Vector3(-xPoint + 1.3f, yPoint, -2.5f);
        spawnedPoint = Instantiate(point, pointPos, Quaternion.identity);

        Invoke("InstantiatePoint2", 1f);
    }

    public void InstantiatePoint2()
    {
        Invoke("InstantiatePoint", 1f);
    }


}
