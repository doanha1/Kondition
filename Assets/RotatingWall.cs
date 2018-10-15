using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWall : MonoBehaviour
{
    public float zspeed = 35f;
    public float xspeed = 0f;

    void Update()
    {
        transform.Rotate(xspeed, 0, zspeed * Time.deltaTime);
    }
}
