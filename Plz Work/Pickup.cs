using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public GameObject item;
    public GameObject tempParent;
    public Transform guide;    
    void Start()
    {        
        item.GetComponent<Rigidbody>().useGravity = true;
    }
    // Update is called once per frame
    void Update()
    {
        float tempx = item.transform.position.x - tempParent.transform.position.x;
        if(tempx < 0)
        {
            tempx *= -1;
        }
        
        float tempz = item.transform.position.z - tempParent.transform.position.z;
        if(tempz < 0)
        {
            tempz *= -1;
        }
        if (Input.GetMouseButton(0) && tempx < 0.5 && tempz < 1)
        {
            OnMouseDown();
        }
             else
        {
            OnMouseUp();
        }
        
    }
    private void OnMouseDown()
    {
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = guide.transform.position;
        item.transform.rotation = guide.transform.rotation;
        item.transform.parent = tempParent.transform;
    
}
    private void OnMouseUp()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;        
        item.transform.parent = null;
        item.transform.rotation = item.transform.localRotation; 
    }
}
