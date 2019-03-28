using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour {

    public LockedDoor script;
    public Key key;
    public GameObject tekstDisplayOpen;
    public GameObject tekstDisplayLocked;
    public GameObject keyUI;
    public Animator gate1;
    public Animator gate2;

    private void Start()
    {
        gate1.enabled = false;
        gate2.enabled = false;
    }

    private void OnTriggerStay(Collider col)
    {
        if(col.tag == "Player")
        {
            OnClick();
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            tekstDisplayLocked.SetActive(false);
            tekstDisplayOpen.SetActive(false);
        }
    }

    void OnClick()
    {
        if(key.key == true)
        {
            tekstDisplayOpen.SetActive(true);
            if (Input.GetKey("e"))
            {
                gate1.enabled = true;
                gate2.enabled = true;
                script.enabled = true;
                tekstDisplayOpen.SetActive(false);
                keyUI.SetActive(false);
                Destroy(this);
            }
        }
        else
        {
            tekstDisplayLocked.SetActive(true);
        }
        
    }

}
