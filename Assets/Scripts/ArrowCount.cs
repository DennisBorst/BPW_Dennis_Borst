using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArrowCount : MonoBehaviour {

    public Shoot arrows;
    public TextMeshProUGUI arrowNumber;
	
	// Update is called once per frame
	void Update () {
        arrowNumber.text = "Arrows: " + arrows.numberOfArrows.ToString("0");
	}
}
