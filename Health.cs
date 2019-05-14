using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
  
    WaitForSeconds waitForSeconds = new WaitForSeconds(1f);
    public GameObject lava;
    public CharacterController steve;
    public int health = 100;    
    Vector3 startpos;
	// Use this for initialization
	void Start () {
        startpos = new Vector3(steve.transform.position.x, steve.transform.position.y, steve.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        float tempx = lava.transform.position.x - steve.transform.position.x;
        if(tempx < 0)
        {
            tempx *= -1;
        }
        
        float tempy = lava.transform.position.y - steve.transform.position.y;
        if(tempy    < 0)
        {
            tempy *= -1;
        }
        float tempz = lava.transform.position.z - steve.transform.position.z;
        if (tempz < 0)
        {
            tempz *= -1;
        }        
        if (1 > tempx && 1 > tempy && 1> tempz)
        {            
            health -= 1;
            if(health == 0)
            {
                steve.transform.position = startpos;
                health = 100;
            }
        }
	}

    
}
