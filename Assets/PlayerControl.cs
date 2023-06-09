using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerControl : MonoBehaviour
{


    //public CharacterController2D controller;
    //public Animatior animatior;


    public Transform groundcheck;
    public LayerMask groundMask;
    private bool ground = false;
    private float groundRadius = 0.5f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ground = Physics2D.OverlapCircle(groundcheck.position, groundRadius, groundMask);
        if (Input.GetMouseButtonDown(0) && ground==true)
        {
            Jump();
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));
    }
}
