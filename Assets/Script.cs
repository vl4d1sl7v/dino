using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    float Q = 2f;
    float W = 0.3f;
    int z = 3;

    public GameObject objects;
    void Start ()
    {
        InvokeRepeating("CreateObjects", W, Q);
        //InvokeRepeating("CreateObjects",0.3f, 2);
    }

    void CreateObjects()
    {
        Instantiate(objects, new Vector3(12.5f, 2.55f, 0), Quaternion.identity);
    }

    /*void Speedy()
    {
        if (ScoreManager.score >= z)
        {
            z += 3;
            Q -= 0.1f;
        }
    }*/
}
