using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Key : MonoBehaviour {

    public GameObject keyUI;
    public GameObject tekst;
    public bool key = false;

    private void OnTriggerStay(Collider col)
    {
        if(col.tag == "Player")
        {
            tekst.SetActive(true);
            OnClick();
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            tekst.SetActive(false);
        }
    }

    void OnClick()
    {
        if (Input.GetKey("e"))
        {
            key = true;
            keyUI.SetActive(true);
            Destroy(gameObject);
            Destroy(tekst);
        }
    }
}
