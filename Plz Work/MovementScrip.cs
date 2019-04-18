using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScrip : MonoBehaviour {
    float speed = 2;
    float rotSpeed = 40;
    float rot = 0f;
    float gravity = 8;
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator anim;
    public GameObject item;
    public GameObject guide;
    void Start () {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();        
        
    }
	
	
	void Update () {
		if(controller.isGrounded)
        {
            if (Input.GetMouseButton(0) && item.transform.IsChildOf(guide.transform))
            {
                anim.SetInteger("condition", 4);
                if (Input.GetKey(KeyCode.W))
                {

                    moveDir = new Vector3(0, 0, 1);
                    moveDir = moveDir * speed;
                    moveDir = transform.TransformDirection(moveDir);
                }
                if (Input.GetKeyUp(KeyCode.W))
                {

                    moveDir = new Vector3(0, 0, 0);
                }
                if (Input.GetKey(KeyCode.S))
                {

                    moveDir = new Vector3(0, 0, -1);
                    moveDir = moveDir * speed;
                    moveDir = transform.TransformDirection(moveDir);
                }
                if (Input.GetKeyUp(KeyCode.S))
                {

                    moveDir = new Vector3(0, 0, 0);
                }
                if (Input.GetKey(KeyCode.D))
                {

                    moveDir = new Vector3(1, 0, 0);
                    moveDir = moveDir * speed;
                    moveDir = transform.TransformDirection(moveDir);
                }
                if (Input.GetKeyUp(KeyCode.D))
                {

                    moveDir = new Vector3(0, 0, 0);
                }
                if (Input.GetKey(KeyCode.A))
                {

                    moveDir = new Vector3(-2, 0, 0);
                    moveDir = moveDir * (speed / 2);
                    moveDir = transform.TransformDirection(moveDir);
                }
                if (Input.GetKeyUp(KeyCode.A))
                {

                    moveDir = new Vector3(0, 0, 0);
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                anim.SetInteger("condition", 0);
                moveDir = new Vector3(0, 0, 0);
            }
            else
            {
                if (Input.GetKey(KeyCode.W))
                {
                    anim.SetInteger("condition", 1);
                    moveDir = new Vector3(0, 0, 1);
                    moveDir = moveDir * speed;
                    moveDir = transform.TransformDirection(moveDir);
                }
                if (Input.GetKeyUp(KeyCode.W))             
                {
                    anim.SetInteger("condition", 0);
                    moveDir = new Vector3(0, 0, 0);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    anim.SetInteger("condition", -1);
                    moveDir = new Vector3(0, 0, -1);
                    moveDir = moveDir * speed;
                    moveDir = transform.TransformDirection(moveDir);
                }
                if (Input.GetKeyUp(KeyCode.S))
                {
                    anim.SetInteger("condition", 0);
                    moveDir = new Vector3(0, 0, 0);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetInteger("condition", 2);
                    moveDir = new Vector3(1, 0, 0);
                    moveDir = moveDir * speed;
                    moveDir = transform.TransformDirection(moveDir);
                }
                if (Input.GetKeyUp(KeyCode.D))
                {
                    anim.SetInteger("condition", 0);
                    moveDir = new Vector3(0, 0, 0);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    anim.SetInteger("condition", 1);
                    moveDir = new Vector3(-2, 0, 0);
                    moveDir = moveDir * (speed / 2);
                    moveDir = transform.TransformDirection(moveDir);
                }
                if (Input.GetKeyUp(KeyCode.A))
                {
                    anim.SetInteger("condition", 0);
                    moveDir = new Vector3(0, 0, 0);
                }
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    if (anim.GetInteger("condition") == 0)
                    {
                        anim.SetInteger("condition", -3);
                    }
                    else
                    {
                        anim.SetInteger("condtion", 0);
                    }
                }
            }
        }




        moveDir.y -= gravity * Time.deltaTime;
        float h = rotSpeed * Input.GetAxis("Mouse X");
        float y = rotSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, h, 0);
        controller.Move(moveDir * Time.deltaTime);
     	   }
}
