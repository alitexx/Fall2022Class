using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScreen : MonoBehaviour
{
    public GameObject itemToRotate;
    void Update()
    {
        itemToRotate.transform.Rotate(0, (float)0.1, 0, Space.Self);
    }
}
