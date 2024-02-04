using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject playAgain;
    public GameObject ball;
    public GameObject mainMenu;
    public Text txtMessage;

    public int whatWall; //this identifies w/c wall the ball hits

    public void OnCollisionEnter2D(Collision2D actor)
    {
        //increments the score depending on w/c wall the ball hits
        if (actor.gameObject.CompareTag("Ball"))
        {
            switch (whatWall)
            {
                case 1:
                    gameManager.p1Score += 1;
                    break;
                case 2:
                    gameManager.p2Score += 1;
                    break;
            }
            switch (whatWall)
            {
                case 1:
                    if (gameManager.p1Score == 12)
                    {
                        txtMessage.text = "Player 1 Wins!"; //display message
                        ball.gameObject.SetActive(false);
                        Player1.gameObject.SetActive(false);
                        Player2.gameObject.SetActive(false);
                        playAgain.gameObject.SetActive(true);
                        mainMenu.gameObject.SetActive(true);
                    }
                    break;
                case 2:
                    if (gameManager.p2Score == 12)
                    {
                        txtMessage.text = "Player 2 Wins!"; //display message
                        ball.gameObject.SetActive(false);
                        Player1.gameObject.SetActive(false);
                        Player2.gameObject.SetActive(false);
                        playAgain.gameObject.SetActive(true);
                        mainMenu.gameObject.SetActive(true);
                    }
                    break;

            }
        }
    }
}
