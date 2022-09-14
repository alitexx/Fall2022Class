using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudFloat : MonoBehaviour
{
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start() // executes FIRST
    {
        //Debug.Log("Hello World!!! :)");
        Debug.Log(this.name);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x ,
            this.transform.position.y , (this.transform.position.z + (speed * Time.deltaTime)));
    }
}
