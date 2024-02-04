using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Breakables : MonoBehaviour
{
    public GameManager gameManager;

    public Text txtMessage;

    public static int noOfBricks = 0; //variable that counts how many bricks are in the scene

    public int brickHP; //this will identify how long will it take the brick to break
    public SpriteRenderer brickSprite; //identifies the sprite renderer component
    public Sprite sDamaged; //referenced to the replacement sprite

    // Start is called before the first frame update
    void Start()
    {
        noOfBricks++; //counts how many game objects are present in the scene
        brickSprite = GetComponent<SpriteRenderer>();
    }

    //this function will check and destroy the bricks
    public void Die()
    {
        noOfBricks--; //decrements the current brick count
        if (noOfBricks <= 0)
        {
            gameManager.isThereAnyBricks = true;
        }
        Destroy(this.gameObject); //destroys the brick object
    }

    public void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.CompareTag("Ball"))
        {
            brickHP -= 1; //decreases the bricks hp
            brickSprite.sprite = sDamaged; //changes the sprite of the brick if damaged
            if (brickHP <= 0)
            {
                Die();
            }
        }
    }
}
