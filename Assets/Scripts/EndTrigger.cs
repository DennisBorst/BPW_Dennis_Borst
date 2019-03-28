using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.Characters.FirstPerson;

public class EndTrigger : MonoBehaviour {

    public GameObject tekst;
    public GameObject fadeOut;
    public GameObject arrowUI;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController playerControls;

    private void OnTriggerStay(Collider col)
    {
        if(col.tag == "Player")
        {
            OnClick();
        }
    }

    void OnClick()
    {
        if (Input.GetKey("e"))
        {
            fadeOut.SetActive(true);
            arrowUI.SetActive(false);
            playerControls.enabled = false;
            playerControls.UnlockCursor();
            //Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            tekst.SetActive(true);
        }
    }

}
