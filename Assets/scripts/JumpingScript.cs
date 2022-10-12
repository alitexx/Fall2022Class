using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float jumpForce = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) //  && (Time.timeScale == 1f) // repurposing code from in-class
        {
            Debug.Log("I am jumping!!");
            rigidBody.AddForce(Vector3.up * jumpForce);
        }
    }
}
