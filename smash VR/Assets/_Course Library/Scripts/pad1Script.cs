using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class pad1script : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        getGrabbed.OnGrabbed += Deactivate;
        getGrabbed.OnReleased += Activate;
    }

    void OnDisable()
    {
        getGrabbed.OnGrabbed -= Deactivate;
        getGrabbed.OnReleased -= Activate;
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
