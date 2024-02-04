using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string levelName;
    public GameObject playAgain;
    public GameObject mainMenu;
    public GameObject ball;
    public GameObject player;

    //variables that holds the score value
    public int p1Score;
    public int p2Score;

    //this variables will display the score on screen
    public Text txtP1Score;
    public Text txtP2Score;

    public bool isThereAnyBricks;
    public Text txtMessage;

    // Update is called once per frame
    void Update()
    {
        if(levelName == "Pong")
        {
            txtP1Score.text = p1Score.ToString();
            txtP2Score.text = p2Score.ToString();
        }
      
        if(levelName == "RicochetStage1")
        {
            if (isThereAnyBricks)
            {
                SceneManager.LoadScene("RicochetStage2");
            }
        }
        if (levelName == "RicochetStage2")
        {
            if (isThereAnyBricks)
            {
                SceneManager.LoadScene("RicochetStage3");
            }
        }
        if (levelName == "RicochetStage3")
        {
            if (isThereAnyBricks)
            {
                txtMessage.text = "You Win";
                ball.gameObject.SetActive(false);
                player.gameObject.SetActive(false);
                playAgain.gameObject.SetActive(true);
                mainMenu.gameObject.SetActive(true);
            }
        }

    }
}

