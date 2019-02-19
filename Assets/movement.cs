using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 50.0f;
    public float sensitivity = 7.0f;
    public Camera_Work camera_script;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        //transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * sensitivity, 0));
    }
    
    void FixedUpdate()
    {
        if (camera_script.in_room1 == true)
        {
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * sensitivity, 0));
        }
        else if (camera_script.in_room3 == true)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
        Vector3 movement;
        
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("in W");
            
            movement = Vector3.forward;
            anim.SetTrigger("run");
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("run_left"))
            {
                anim.SetTrigger("run");
            }
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("run_right"))
            {
                anim.SetTrigger("run");
            }
            

            if (camera_script.in_room2 == true)
            {
                rb.AddForce(movement * speed);
                transform.rotation = Quaternion.LookRotation(movement);
            }
            else if (camera_script.in_room3 == true)
            {
                movement = Vector3.back;
                rb.AddForce(movement * speed);
                
            }
            else
            {
                rb.AddRelativeForce(movement * speed);
            }
            
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement = Vector3.back;
            anim.SetTrigger("run");
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("run_left"))
            {
                anim.SetTrigger("run");
            }
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("run_right"))
            {
                anim.SetTrigger("run");
            }
            
            if (camera_script.in_room2 == true)
            {
                rb.AddForce(movement * speed);
                transform.rotation = Quaternion.LookRotation(movement);
            }
            else if (camera_script.in_room3 == true)
            {
                movement = Vector3.forward;
                rb.AddForce(movement * speed);
            }
            else
            {
                rb.AddRelativeForce(movement * speed);
            }
        }

        else if (Input.GetKey(KeyCode.A))
        {
            movement = Vector3.left;
            anim.SetTrigger("run_left");
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("run_right"))
            {
                anim.SetTrigger("run_left");
            }
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("run"))
            {
                anim.SetTrigger("run_left");
            }
            

            if (camera_script.in_room2 == true)
            {
                rb.AddForce(movement * speed);
                transform.rotation = Quaternion.LookRotation(movement);
            }
            else if (camera_script.in_room3 == true)
            {
                movement = Vector3.right;
                rb.AddForce(movement * speed);
            }
            else
            {
                rb.AddRelativeForce(movement * speed);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetTrigger("run_right");
            movement = Vector3.right;
            
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("run_left"))
            {
                Debug.Log("is this working");
                anim.SetTrigger("run_right");
            }
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("run"))
            {
                anim.SetTrigger("run_right");
            }
            
            if (camera_script.in_room2 == true)
            {
                rb.AddForce(movement * speed);
                transform.rotation = Quaternion.LookRotation(movement);
            }
            else if (camera_script.in_room3 == true)
            {
                movement = Vector3.left;
                rb.AddForce(movement * speed);
            }
            else
            {
                rb.AddRelativeForce(movement * speed);
            }
        }
        else
        {
            anim.SetTrigger("idle");
        }
        

        

    }

    
}
