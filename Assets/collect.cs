using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collect : MonoBehaviour
{
    public Text text;
    //int count = 0;
    public ParticleSystem particle;
    public ParticleSystem particle2;
    public ParticleSystem particle3;
    public bool has_key1;
    public bool has_key2;
    public bool has_power_up;
    public Animator anim;
    public Animator anim2;
    
    // Start is called before the first frame update
    void Start()
    {
        has_key1 = false;
        has_key2 = false;
        has_power_up = false;
        anim = anim.gameObject.GetComponent<Animator>();
        anim2 = anim2.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (anim.GetCurrentAnimatorStateInfo(0).IsName("door_open"))
        {
            anim.SetTrigger("close");
        }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("collectable1"))
        {
            particle.Emit(50);
            Destroy(collision.gameObject);
            //count += 1;
            text.text = "try opening door in front of you";
            has_key1 = true;
        }

        if (collision.gameObject.CompareTag("collectable2"))
        {
            particle2.Emit(50);
            Destroy(collision.gameObject);
            //count += 1;
            text.text = "try opening the other door";
            has_key2 = true;
        }

        if (collision.gameObject.CompareTag("collectable"))
        {
            particle3.Emit(100);
            Destroy(collision.gameObject);
            //count += 1;
            text.text = "press space to shoot!!!";
            has_power_up = true;
        }

        if (collision.gameObject.CompareTag("door1") && has_key1 == true)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("waiting"))
            {
                anim.SetTrigger("open");
            }
        }

        if (collision.gameObject.CompareTag("door2") && has_key2 == true)
        {
            Debug.Log("should open door 2");
            if (anim2.GetCurrentAnimatorStateInfo(0).IsName("waiting"))
            {
                anim2.SetTrigger("open");
            }
        }
    }

    /*private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("door"))
        {
            if (open == true)
            {
                anim.SetTrigger("waiting");
            }
        }
        else
        {
            open = false;
            anim.SetTrigger("close");
        }
    }*/
}
