using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    [SerializeField]
    GameObject arrowPrefab;
    [SerializeField]
    float pullSpeed;
    [SerializeField]
    GameObject arrow;
    [SerializeField]
    GameObject bow;
    [SerializeField]
    public int numberOfArrows = 0;
    bool arrowSlotted = false;
    float pullAmount = 0;
	
	// Update is called once per frame
	void Update () {
        SpawnArrow();
        ShootLogic();
	}

    public void AddArrows(int arrows)
    {
        numberOfArrows = Mathf.Clamp(numberOfArrows + arrows, 0, 10);
    }


    void SpawnArrow()
    {
        if(numberOfArrows > 0 && !arrowSlotted)
        {
            arrowSlotted = true;
            arrow = Instantiate(arrowPrefab, transform.position, transform.rotation) as GameObject;
            arrow.transform.parent = transform;
        }
    }

    public void ShootLogic()
    {
        if(numberOfArrows > 0)
        {
            if (pullAmount > 100)
                pullAmount = 100;

            SkinnedMeshRenderer _bowSkin = bow.transform.GetComponent<SkinnedMeshRenderer>();
            SkinnedMeshRenderer _arrowSkin = arrow.transform.GetComponent<SkinnedMeshRenderer>();
            Rigidbody _arrowRigidb = arrow.transform.GetComponent<Rigidbody>();
            ProjectileAddForce _arrowProjectile = arrow.transform.GetComponent<ProjectileAddForce>();

            if (Input.GetMouseButton(0))
            {
                pullAmount += Time.deltaTime * pullSpeed;
            }
            if (Input.GetMouseButtonUp(0))
            {
                arrowSlotted = false;
                _arrowRigidb.isKinematic = false;
                _arrowRigidb.collisionDetectionMode = CollisionDetectionMode.Continuous;
                arrow.transform.parent = null;
                _arrowProjectile.shootForce = _arrowProjectile.shootForce * ((pullAmount / 100) + .05f);
                numberOfArrows -= 1;

                pullAmount = 0;
                Debug.Log("I DID MAKE IT HERE");
                _arrowProjectile.enabled = true;
                Debug.Log("this is enabled");

            }

            _bowSkin.SetBlendShapeWeight(0, pullAmount);
            _arrowSkin.SetBlendShapeWeight(0, pullAmount);

            if(Input.GetMouseButtonDown(0) && arrowSlotted == false)
            {
                SpawnArrow();
            }
        }
    }
}
