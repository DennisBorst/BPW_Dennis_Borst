using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmbedBehavior : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    private void OnCollisionEnter(Collision coll)
    {
        Debug.Log(coll.gameObject.name);
        Embed();
    }
    
    void Embed()
    {
        transform.GetComponent<ProjectileAddForce>().enabled = false;
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        rb.isKinematic = true;
    }
}
