using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perspective : MonoBehaviour
{
    public bool firstperson;
    public bool thirdperson;
    public GameObject player;
    public float sensitivity = 7.0f;
    bool reset = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetFirstPerson()
    {
        firstperson = true;
        thirdperson = false;
    }

    public void SetThirdPerson()
    {
        firstperson = false;
        thirdperson = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (firstperson)
        {
            transform.position = player.transform.position;
            if (reset == true)
            {
                transform.eulerAngles = Vector3.zero;
                reset = false;
            }
            transform.rotation = player.transform.rotation;
            
        }
        else if (thirdperson)
        {
            reset = true;
            transform.eulerAngles = new Vector3(25, player.transform.eulerAngles.y, player.transform.eulerAngles.z);
            transform.position = player.transform.position + new Vector3(0, 7, -10);
            
        }
    }
}
