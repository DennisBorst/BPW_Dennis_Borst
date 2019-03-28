using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public GameObject trigger;

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            trigger.SetActive(true);
        }
    }
}
