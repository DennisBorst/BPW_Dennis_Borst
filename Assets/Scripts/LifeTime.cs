using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour {

    public float lifeTime = 10;
    private float currentLifeTime = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "projectiles")
        {
            currentLifeTime += Time.deltaTime;
            if (currentLifeTime > lifeTime)
            {
                Destroy(gameObject);
            }
        }
    }
}
