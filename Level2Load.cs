using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level2Load : MonoBehaviour {

    private GameObject playerObj = null;
    Bounds finishSquare;

	// Use this for initialization
	void Start ()
    {
        if (playerObj == null)
            playerObj = GameObject.Find("Robot Kyle (1)");
	}
	
    Vector3 GetStevePosition()
    {
        return playerObj.transform.position;
    }
	// Update is called once per frame
	void Update ()
    {

        Debug.Log(GetStevePosition());

        finishSquare = new Bounds(new Vector3(16.4f, 100.2f, 26.3f), new Vector3(5.0f,1.0f,5.0f));
        if(finishSquare.Contains(GetStevePosition()))
        {
          SceneManager.LoadScene(2);
        }
    }
}
