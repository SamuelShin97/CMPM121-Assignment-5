using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public collect coll;
    public GameObject bullet;
    public float bullet_speed = 50.0F;
    public float destroy_time = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && coll.has_power_up == true)
        {
            GameObject bul = Instantiate(bullet);
            bul.gameObject.GetComponent<Transform>().position = transform.position + transform.forward + new Vector3(0, 2, 0);
            bul.gameObject.GetComponent<Rigidbody>().velocity = bullet_speed * transform.forward;
            Destroy(bul, destroy_time);
        }
        
    }

 
}
