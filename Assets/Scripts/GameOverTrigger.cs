using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverTrigger : MonoBehaviour
{
    public Text txtMessage; //displays the message on screen
    public GameObject ball; //reference to the ball object
    public GameObject playAgain;
    public GameObject mainMenu;
    public GameObject player;

    public void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.CompareTag("Ball"))
        {
            txtMessage.text = "Game Over!"; //display message
            ball.gameObject.SetActive(false);
            player.gameObject.SetActive(false);
            playAgain.gameObject.SetActive(true);
            mainMenu.gameObject.SetActive(true);
        }
    }
}
