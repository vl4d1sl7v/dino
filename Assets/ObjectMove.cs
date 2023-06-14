using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    float s = 0.13f;
    int z = 3;

    void FixedUpdate ()
    {
        transform.position = new Vector3(transform.position.x - s, transform.position.y, 0);
        //Speedy();
    }

    /*void Speedy()
    {
        if (ScoreManager.score >= z)
        {
            z += 3;
            s += 0.1f;
        }
    }*/
}
