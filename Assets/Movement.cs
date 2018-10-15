using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rbody;
    public float force = 20f;

    void Start()
    {

    }


    void Update()
    {

        //AddForce
        //.velocity
        //( MovePosition() )

        //AddTorque
        //.angularVelocity
        //( MoveRotation() )

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Level0");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
        rbody.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbody.AddForce(new Vector2(-force, 0f));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rbody.AddForce(new Vector2(force, 0f));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rbody.AddForce(new Vector2(0f, force));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rbody.AddForce(new Vector2(0f, -force));
        }
    }

    //Enter
    //Exit
    //Stay
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Hit!");
        SceneManager.LoadScene("Level0");
    }
}
