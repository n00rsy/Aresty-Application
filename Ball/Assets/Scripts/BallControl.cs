using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    // Use this for initialization

    private Rigidbody rb;

    public float speed;
    public float jumpSpeed;
    public float airDamp;
    public float maxSpeed;

    public GameControl gc;

    private bool canJump;


	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        if (canJump)
        {
            Vector3 movement = new Vector3(horizontal, jump * jumpSpeed, vertical);
            rb.AddForce(movement * speed);
        }
        else
        {
            Vector3 movement = new Vector3(horizontal, 0, vertical);
            rb.AddForce(movement * speed/airDamp);
        }

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("asdfasdf");
        if (other.gameObject.tag == "Floor")
        {
            canJump = true;
        }
        else if (other.gameObject.tag == "NoTouch")
        {
            gc.GetComponent<GameControl>().decreaseScore();
        }

        else if (other.gameObject.tag == "Touch")
        {
            gc.GetComponent<GameControl>().increaseScore();
            Destroy(other.gameObject);
        }

    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("dfghfghdg");
        if (other.gameObject.tag == "Floor")
        {
            canJump = false;
        }
    }



}
