using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatForm : MonoBehaviour
{
    public Transform platform;
    public Rigidbody rigidBody;
    public float moveSpeed;
    /// <summary>
    /// 1 = x, 2 = y, 3 = z
    /// </summary>
    public int eixo;
    public float start, limit;

    private bool direction;
    void Start()
    {
        direction = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (eixo == 1)
        {
            if (direction)
            {
                if (limit < platform.position.x)
                {
                    direction = false;
                }
                else
                {
                    rigidBody.velocity = new Vector3(moveSpeed, 0, 0);
                }
            }
            else
            {
                if (start > platform.position.x)
                {
                    direction = true;
                }
                else
                {
                    rigidBody.velocity = new Vector3(-moveSpeed, 0, 0);
                }
            }
        }
        else if (eixo == 2)
        {
            if (direction)
            {
                if (limit < platform.position.y)
                {
                    direction = false;
                }
                else
                {
                    rigidBody.velocity = new Vector3(0,moveSpeed, 0);
                }
            }
            else
            {
                if (start > platform.position.y)
                {
                    direction = true;
                }
                else
                {
                    rigidBody.velocity = new Vector3(0, -moveSpeed, 0);
                }
            }
        }
        else if(eixo == 3)
        {
            if (direction)
            {
                if (limit < platform.position.z)
                {
                    direction = false;
                }
                else
                {
                    rigidBody.velocity = new Vector3(0, 0, moveSpeed);
                }
            }
            else
            {
                if (start > platform.position.z)
                {
                    direction = true;
                }
                else
                {
                    rigidBody.velocity = new Vector3(0, 0, -moveSpeed);
                }
            }
        }


    }
}
