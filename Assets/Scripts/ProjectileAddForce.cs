using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAddForce : MonoBehaviour {

    Rigidbody rb;
    public float shootForce = 2000;
    public float arrowLifetime = 10;
    private float currentLifetime = 0;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        ApplyForce();
        Debug.Log("I am shooting");
	}
	
	// Update is called once per frame
	void Update () {
        SpinObjectInAir();
	}

    void ApplyForce()
    {
        rb.AddRelativeForce(Vector3.forward * shootForce);
        Debug.Log("I made it this far");
    }

    void SpinObjectInAir()
    {
        float _yVelocity = rb.velocity.y;
        float _zVelocity = rb.velocity.z;
        float _xVelocity = rb.velocity.x;

        float _combinedVelocity = Mathf.Sqrt(_xVelocity * _xVelocity + _zVelocity * _zVelocity);
        float _fallAngle = -1 * Mathf.Atan2(_yVelocity, _combinedVelocity) * 180 / Mathf.PI;

        transform.eulerAngles = new Vector3(_fallAngle, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
