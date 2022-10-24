using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{

    public void moveToHome()
    {
        SceneManager.LoadScene("Menu"); //Once the method(Home Button pressed) is called, transition to the main menu
    }
}
