using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 3.5f;
    public float rotatingSpeed = 40f;
    public float jumpingForce = 10f;
    
    private bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey("right"))
        {
            transform.RotateAround(transform.position, Vector3.up, rotatingSpeed * Time.deltaTime);
            Debug.Log("Turn Right");
        }

        if (Input.GetKey("left"))
        {
            transform.RotateAround(transform.position, Vector3.up, -rotatingSpeed * Time.deltaTime);
            Debug.Log("Move Left");
        }

        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            Debug.Log("Move Up");
        }

        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
            Debug.Log("Move Down");
        }

        if (Input.GetKeyDown("space") && canJump)
        {
            canJump = false;
            GetComponent<Rigidbody>().AddForce(0, jumpingForce, 0);
            Debug.Log("Jump");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Floor")
        {
            Debug.Log("Hit the floor");
            canJump = true;
        }
    }
}
