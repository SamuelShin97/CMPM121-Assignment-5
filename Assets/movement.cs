using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 50.0f;
    public float sensitivity = 7.0f;
    public Camera_Work camera_script;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * sensitivity, 0));
    }
    
    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 movement;
        if (Input.GetKey(KeyCode.W))
        {
            movement = Vector3.forward;
            if (camera_script.in_room2 == true)
            {
                rb.AddForce(movement * speed);
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
            if (camera_script.in_room2 == true)
            {
                rb.AddForce(movement * speed);
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
        if (Input.GetKey(KeyCode.A))
        {
            movement = Vector3.left;
            if (camera_script.in_room2 == true)
            {
                rb.AddForce(movement * speed);
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
            movement = Vector3.right;
            if (camera_script.in_room2 == true)
            {
                rb.AddForce(movement * speed);
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

    }

    
}
