using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeper : MonoBehaviour
{
    static int score;
   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            score++;
            Debug.Log("The score has gone up! The players has " + score.ToString() + " points!");
        }
        

    }
}
