using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed; //ball's movement speed
    public Rigidbody2D ballRB; //reference to the rb2d component

    // Start is called before the first frame update
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
        //determnes the initial direction of the ball
        int rnd = Random.Range(0, 2);
        switch (rnd)
        {
            case 1:
                ballRB.velocity = Vector2.right * speed;
                break;
            default:
                ballRB.velocity = Vector2.left * speed;
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.name == "Player1")
        {
            float y = calculatePosition(transform.position, actor.transform.position, actor.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            ballRB.velocity = direction * speed;
        }

        if (actor.gameObject.name == "Player2")
        {
            float y = calculatePosition(transform.position, actor.transform.position, actor.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;
            ballRB.velocity = direction * speed;
        }
    }

    float calculatePosition(Vector2 ballPosition, Vector2 panelPosition, float panelHeight)
    {
        float value = (ballPosition.y - panelPosition.y) / panelHeight;
        return (value);
    }

}
