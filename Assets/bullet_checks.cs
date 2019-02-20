using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bullet_checks : MonoBehaviour
{
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            text.text = "Nice! That's all there is!";
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //do nothing
        }

        /*if (collision.collider.tag == "wall" || collision.collider.tag == "floor1" || collision.collider.tag == "floor2" ||
                collision.collider.tag == "floor3" || collision.collider.tag == "door1" || collision.collider.tag == "door2")
        {
            Destroy(this.gameObject);
        }*/
    }
}
