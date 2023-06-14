using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerControl : MonoBehaviour
{


    public CharacterController Controller;
    public Animator Animator;

    
    public Transform groundcheck;
    public LayerMask groundMask;
    private bool ground = false;
    private float groundRadius = 0.5f;


    void Update()
    {
        ground = Physics2D.OverlapCircle(groundcheck.position, groundRadius, groundMask);
        if (Input.GetMouseButtonDown(0) && ground==true)
        {
            Jump();
            Animator.SetBool("jumping", true);
        }

        else
        {
            Animator.SetBool("jumping", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            SceneManager.LoadScene(2);
        }
        if (collision.tag == "Score")
        {
            ScoreManager.score += 1;
        }
    }



    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));
    }
}
