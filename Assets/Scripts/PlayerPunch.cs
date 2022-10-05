using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch : MonoBehaviour
{
    Animator myAnim;
    //Rigidbody myBody;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        //myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            myAnim.SetBool("punched", true);
            Destroy(gameObject);
        }
    }
}
