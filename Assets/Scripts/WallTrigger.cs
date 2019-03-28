using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour {

    public Animator gate1;
    public Animator gate2;
    public bool targetHit = false;
    public GameObject thisTarget;
    public GameObject greenTarget;

    private void Start()
    {
        gate1.enabled = false;
        gate2.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectiles")
        {
            targetHit = true;
            gate1.enabled = true;
            gate2.enabled = true;
            greenTarget.SetActive(true);
            thisTarget.SetActive(false);
        }
    }
}
