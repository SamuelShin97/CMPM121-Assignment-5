using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dr_who_angel_behavior : MonoBehaviour
{
    public GameObject player;
    Renderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Renderer.isVisible)
        {
            RaycastHit hit;
            Vector3 direction = Camera.main.transform.position - transform.position;
            if (Physics.Raycast(transform.position, direction, out hit))
            {
                if (hit.collider.tag != "MainCamera" && hit.collider.tag != "Player") //hit something else before the camera
                {
                    Debug.Log("Object is not visible");
                    transform.LookAt(player.transform.position);
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, 
                        transform.position.y, player.transform.position.z), 5 * Time.deltaTime);
                }
                else
                {
                    Debug.Log("Object is visible");
                    transform.position = transform.position;
                    
                }
                Debug.DrawRay(transform.position, direction, Color.green);
            }
            else
            {
                Debug.Log("Object is visible2");
                transform.position = transform.position;
            }
        }
        else
        {
            Debug.Log("Object is no longer visible");
            transform.LookAt(player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x,
                        transform.position.y, player.transform.position.z), 5 * Time.deltaTime);
        }
    }
}
