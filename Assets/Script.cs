using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public GameObject objects;
    // Start is called before the first frame update
    void Start ()
    {
        InvokeRepeating("CreateObjects",0.3f, 2);
    }

    void CreateObjects()
    {
        Instantiate(objects, new Vector3(12.5f, 2.55f, 0), Quaternion.identity);
    }

    // Update is called once per frame

}
