using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Work : MonoBehaviour
{
    public GameObject room1_camera;
    public GameObject room2_camera;
    public GameObject room3_camera;
    public bool in_room1 = false;
    public bool in_room2 = false;
    public bool in_room3 = false;
    public Animator anim;
    public Animator anim2;

    // Start is called before the first frame update
    void Start()
    {
        anim = anim.gameObject.GetComponent<Animator>();
        anim2 = anim2.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("floor1"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("door_open"))
            {
                Debug.Log("close door");
                anim.SetTrigger("close");
            }
            if (anim2.GetCurrentAnimatorStateInfo(0).IsName("door_open"))
            {
                Debug.Log("close door");
                anim2.SetTrigger("close");
            }
            Debug.Log("in room 1");
            room1_camera.SetActive(true);
            room2_camera.SetActive(false);
            room3_camera.SetActive(false);
            in_room1 = true;
            in_room2 = false;
            in_room3 = false;
        }
        else if (collision.gameObject.CompareTag("floor2"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("door_open"))
            {
                Debug.Log("close door");
                anim.SetTrigger("close");
            }
            if (anim2.GetCurrentAnimatorStateInfo(0).IsName("door_open"))
            {
                Debug.Log("close door");
                anim2.SetTrigger("close");
            }
            Debug.Log("in room 2");
            room1_camera.SetActive(false);
            room2_camera.SetActive(true);
            room3_camera.SetActive(false);
            in_room1 = false;
            in_room2 = true;
            in_room3 = false;
        }
        else if (collision.gameObject.CompareTag("floor3"))
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("door_open"))
            {
                Debug.Log("close door");
                anim.SetTrigger("close");
            }
            if (anim2.GetCurrentAnimatorStateInfo(0).IsName("door_open"))
            {
                Debug.Log("close door");
                anim2.SetTrigger("close");
            }
            Debug.Log("in room 3");
            room1_camera.SetActive(false);
            room2_camera.SetActive(false);
            room3_camera.SetActive(true);
            in_room1 = false;
            in_room2 = false;
            in_room3 = true;
        }
    }
}
