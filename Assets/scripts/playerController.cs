using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{


    public CharacterController charController;

    public float speed = 1.0f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get current pos
        Vector3 currentPos = transform.position;
        Vector3 motion = Vector3.zero;
        // get player input
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        currentPos.x = (currentPos.x + speed) * inputX * Time.deltaTime;
        motion.x = speed*inputX * Time.deltaTime;
        // change to motion = (transform.right * speed * inputX * Time.deltaTime) + (transform.forward * speed * inputY * Time.deltaTime); 
        // ^ only if the player is rotated and what not


        currentPos.z = (currentPos.z + speed) * inputY * Time.deltaTime;
        motion.z = speed*inputY * Time.deltaTime;


        //transform.position = currentPos;
        charController.Move(motion);
    }
}
