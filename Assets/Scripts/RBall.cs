using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBall : MonoBehaviour
{
    public float speed; //ball's movement speed
    public Rigidbody2D ballRB; //reference to the rb2d component

    // Start is called before the first frame update
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
        //determnes the initial direction of the ball (left)
        ballRB.velocity = Vector2.left * speed;
    }

    private void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.name == "Player1")
        {
            float y = calculatePosition(transform.position, actor.transform.position, actor.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            ballRB.velocity = direction * speed;
        }
    }

    float calculatePosition(Vector2 ballPosition, Vector2 panelPosition, float panelHeight)
    {
        float value = (ballPosition.y - panelPosition.y) / panelHeight;
        return (value);
    }
}
