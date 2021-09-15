using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableRotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var oldRotation = transform.rotation;
        transform.Rotate(Time.deltaTime * 90, Time.deltaTime*90, 0);
        var newRotation = transform.rotation;

            transform.rotation = Quaternion.Slerp(oldRotation, newRotation, 0);


        transform.rotation = newRotation; // To make it come out at exactly 90 degrees
    }
}
