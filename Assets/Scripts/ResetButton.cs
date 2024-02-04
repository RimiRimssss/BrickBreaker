using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    public string whatScene;

    public void BtnReset()
    {
        SceneManager.LoadScene(whatScene);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            BtnReset();
        }
        else if (Input.GetKey(KeyCode.Keypad0)) 
        {
            BtnReset();
        }
    }
}
