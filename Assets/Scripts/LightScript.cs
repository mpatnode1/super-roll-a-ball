using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightScript : MonoBehaviour
{
    public bool onlyTriggerOnce = false;
    public UnityEvent OnTriggerEntered;
    public GameObject arrow;
    public Material OnMaterial;
    public Material OffMaterial;

    private bool _hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered trigger");

        bool isPlayer = other.GetComponent<PlayerController>() != null;

        if (isPlayer)
        {
            arrow.GetComponent<Renderer>().material = OnMaterial;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Something entered trigger");

        bool isPlayer = other.GetComponent<PlayerController>() != null;

        if (isPlayer)
        {
            arrow.GetComponent<Renderer>().material = OffMaterial;
        }
    }
}
