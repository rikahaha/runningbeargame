using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    private Rigidbody2D rbody;
    private Animator ani;
    public static int HP = 1;


    void Start()
    {// box
        rbody = GetComponent<Rigidbody2D>();

        ani = GetComponent<Animator>();

    }
    void Update()
    {
        if (playercontrol.HP == 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "die" && playercontrol.HP > 0)
        {
            HP = 0;
        }



    }
    public void Jump()
    {
        rbody.AddForce(Vector2.up * 400);
    }
}
