using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{
    public Light treeLight;
    private void OnTriggerEnter(Collider other)
    {
        //var light = GetComponent<Light>();
        treeLight.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
       // var light = GetComponent<Light>();
        treeLight.enabled = false;
    }
}
