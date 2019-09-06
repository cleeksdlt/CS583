using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Vert : MonoBehaviour {

    float vertSpeed = 3f;
    Vector3 direction;


    // Use this for initialization
    void Start () {
        direction = Vector3.up;
	}
	
	// Update is called once per frame
    void Update () {
        transform.root.position += direction * Time.deltaTime * vertSpeed;
        if (transform.position.y >= 24f)
        {
            changeDown();
        }
        if (transform.position.y <= 3f)
        {
            changeUp();
        }

    }

    void changeDown() {
        direction = Vector3.down;
    }

    void changeUp() {
        direction = Vector3.up;
    }
}
