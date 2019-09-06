using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Rotation : MonoBehaviour {

    float rotations = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, (float)(3.0 * rotations * Time.deltaTime));
	}
}
