using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject linePoint;
    public GameObject coordinatePlane;
    private GameObject obj;

    public Slider aSlider;
    public Slider bSlider;
    public Slider cSlider;

    public Text aTxt;
    public Text bTxt;
    public Text cTxt;

    private float aVal;
    private float cVal;
    private float bVal;
    private float xVal;
    private float yVal;

    private Vector2 coordinate;
    private Vector3 spawnPoint;


    void Update()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        aTxt.text = aSlider.value.ToString();
        bTxt.text = bSlider.value.ToString();
        cTxt.text = cSlider.value.ToString();
    }

    public void DrawFunction()
    {
        aVal = aSlider.value / 10;
        bVal = bSlider.value / 10;
        cVal = cSlider.value / 10;
        xVal = -3;

        while(xVal < 3)
        {
            yVal = ((-aVal * xVal) - cVal) / bVal;
            coordinate = new Vector2(xVal, yVal);
         

            spawnPoint = new Vector3(xVal, yVal, -2.5f);
            obj = Instantiate(linePoint, spawnPoint, Quaternion.identity);
            obj.transform.parent = coordinatePlane.transform;
            xVal += 0.1f;
        }
    }
}
