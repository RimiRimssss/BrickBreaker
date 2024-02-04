using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; //movement speed
    public float boundY; //y axis movement

    public Rigidbody2D playerPanel; //reference to the rb2d component

    public int wcPlayer; //identifies the player 1 and player 2

    // Start is called before the first frame update
    void Start()
    {
        playerPanel = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var panelVelocity = playerPanel.velocity;

        //p1 controller
        if (wcPlayer == 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                panelVelocity.y = speed;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                panelVelocity.y = -speed;
            }
            else
            {
                panelVelocity.y = 0;
            }
        }

        //p2 controller
        if (wcPlayer == 2)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                panelVelocity.y = speed;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                panelVelocity.y = -speed;
            }
            else
            {
                panelVelocity.y = 0;
            }
        }
        playerPanel.velocity = panelVelocity;

        //this is for the bounds limit
        var panelPos = transform.position;
        if (panelPos.y > boundY)
        {
            panelPos.y = boundY;
        }
        else if (panelPos.y < -boundY)
        {
            panelPos.y = -boundY;
        }
        transform.position = panelPos;
    }
}