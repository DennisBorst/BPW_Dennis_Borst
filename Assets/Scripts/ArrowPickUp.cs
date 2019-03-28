using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPickUp : MonoBehaviour {

    public GameObject tekstWolkje;
    public Shoot arrows;

    private void OnTriggerStay(Collider col)
    {
        if(col.tag == "Player")
        {
            tekstWolkje.SetActive(true);
            OnClick();
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            tekstWolkje.SetActive(false);
        }
    }

    void OnClick()
    {
        Debug.Log("KLIK ME");
        if (Input.GetKey("e"))
        {
            Debug.Log("OH JA IK BEN GEKLIKT");
            arrows.AddArrows(20);
        }
    }
}
