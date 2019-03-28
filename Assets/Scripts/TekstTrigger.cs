using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TekstTrigger : MonoBehaviour {

    public WallTrigger target;
    public GameObject tekstDisplay;

    private void OnTriggerEnter(Collider other)
    {
        if(target.targetHit == false)
        {
            if (other.gameObject.tag == "Player")
            {
                tekstDisplay.SetActive(true);
            }
        }
        else
        {
            tekstDisplay.SetActive(false);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tekstDisplay.SetActive(false);
        }
    }
}
