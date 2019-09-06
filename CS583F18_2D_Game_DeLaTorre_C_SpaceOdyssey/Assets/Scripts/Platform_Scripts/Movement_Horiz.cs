using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Horiz : MonoBehaviour {

    float horizSpeed = 2f;
    Vector3 direction;

    // Use this for initialization
    void Start () {
        direction = Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
        transform.root.position += direction * Time.deltaTime * horizSpeed;
        if (transform.position.x >= -104f) {
            changeLeft();
        }
        if(transform.position.x <= -125f) {
            changeRight();
        }
    }

    void changeLeft() {
        direction = Vector3.left;
    }

    void changeRight()
    {
        direction = Vector3.right;
    }

}
