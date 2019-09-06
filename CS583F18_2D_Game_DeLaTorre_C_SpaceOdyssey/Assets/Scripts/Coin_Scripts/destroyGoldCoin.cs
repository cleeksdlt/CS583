using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyGoldCoin : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Final_Level"));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(4);
        }

    }
}
