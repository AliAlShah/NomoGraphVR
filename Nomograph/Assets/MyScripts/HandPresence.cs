using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class HandPresence : MonoBehaviour
{
    private InputDevice targetDevice;
    private GameObject spawnedHandModel;
    private Animator handAnimator;

    public InputDeviceCharacteristics controllerCharacteristics;
    public GameObject handModelPrefab;
   
 
    void Start()
    {
        TryInitialize();
    }

    void UpdateHandAnimation()
    {
        if(targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            handAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
            handAnimator.SetFloat("Trigger", 0);
        }

        if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("Grip", gripValue);
        }
        else
        {
            handAnimator.SetFloat("Grip", 0);
        }
    }

    void TryInitialize()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }
        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }
        spawnedHandModel = Instantiate(handModelPrefab, transform);
        handAnimator = spawnedHandModel.GetComponent<Animator>();
    }

    
    void Update()
    {
        if (!targetDevice.isValid)
        {
            TryInitialize();
        }
        else
        {
            UpdateHandAnimation();
        }
        
        
    }
}
