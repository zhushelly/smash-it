using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class pad2script : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        getGrabbed.OnGrabbed += Activate;
        getGrabbed.OnReleased += Deactivate;
    }

    void OnDisable()
    {
        getGrabbed.OnGrabbed -= Activate;
        getGrabbed.OnReleased -= Deactivate;
    }

    void Deactivate()
    {
        // deactivate children of the game object
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    void Activate()
    {
        // activate children of the game object
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
