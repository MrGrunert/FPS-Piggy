using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energysaver : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        var light = GetComponent<Light>();
        light.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        var light = GetComponent<Light>();
        light.enabled = false;
    }
}
