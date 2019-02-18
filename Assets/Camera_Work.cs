using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Work : MonoBehaviour
{
    public GameObject room1_camera;
    public GameObject room2_camera;
    public GameObject room3_camera;
    public bool in_room2 = false;
    public bool in_room3 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("floor1"))
        {
            Debug.Log("in room 1");
            room1_camera.SetActive(true);
            room2_camera.SetActive(false);
            room3_camera.SetActive(false);
            in_room2 = false;
            in_room3 = false;
        }
        else if (collision.gameObject.CompareTag("floor2"))
        {
            Debug.Log("in room 2");
            room1_camera.SetActive(false);
            room2_camera.SetActive(true);
            room3_camera.SetActive(false);
            in_room2 = true;
            in_room3 = false;
        }
        else if (collision.gameObject.CompareTag("floor3"))
        {
            Debug.Log("in room 3");
            room1_camera.SetActive(false);
            room2_camera.SetActive(false);
            room3_camera.SetActive(true);
            in_room2 = false;
            in_room3 = true;
        }
    }
}
