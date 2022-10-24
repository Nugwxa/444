using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public string LevelOne;
    public string DigitSpan;
    public int DigitSpanAttempts;
    public string SpatialSpan;

    public Text DigitSpanBestText;
    public Text DigitSpanAttemptsText;

    public int SpatialSpanAttempts;
    public Text SpatialSpanBestText;
    public Text SpatialSpanAttemptsText;

    public GameObject MaxAttempts;
    // Start is called before the first frame update
    void Start()
    {

        //Spatial Span
        SpatialSpanAttempts = PlayerPrefs.GetInt("SpatialSpanAttempts");

        SpatialSpanAttemptsText.text = "Attempts: " + PlayerPrefs.GetInt("SpatialSpanAttempts", DigitSpanAttempts).ToString();


        SpatialSpanBestText.text = "Best Level: " + PlayerPrefs.GetInt("Spatial1BestLevel", 0).ToString();

        //Digit Span

        DigitSpanAttempts = PlayerPrefs.GetInt("DigitSpanAttempts"); 

        DigitSpanAttemptsText.text = "Attempts: " + PlayerPrefs.GetInt("DigitSpanAttempts", DigitSpanAttempts).ToString();


        DigitSpanBestText.text = "Best Level: " + PlayerPrefs.GetInt("Digit1BestLevel", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            Reset();
        }


    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(LevelOne);
        Debug.Log("Level One Begins");
    }

    public void StartDigitSpan()
    {
        if (DigitSpanAttempts > 14)
        {
            MaxAttempts.SetActive(true);
        }
        else
        {
            DigitSpanAttempts = DigitSpanAttempts + 1;

            PlayerPrefs.SetInt("DigitSpanAttempts", DigitSpanAttempts);

            SceneManager.LoadSceneAsync(DigitSpan);
            Debug.Log("Digit Span Begins");
        }
        

        
    }

    public void StartSpatialSpan()
    {
        if (SpatialSpanAttempts > 14)
        {
            MaxAttempts.SetActive(true);
        }
        else
        {
            SpatialSpanAttempts = SpatialSpanAttempts + 1;

            PlayerPrefs.SetInt("SpatialSpanAttempts", SpatialSpanAttempts);

            SceneManager.LoadSceneAsync(SpatialSpan);
            Debug.Log("Spatial Span Begins");
        }
    }

    public void QuitGame() //Closses the application
    {
        Application.Quit();
        Debug.Log("Application Closed Succesfully");

    }

    public void Reset() //Resets User's Attemps
    { 
        PlayerPrefs.DeleteAll();
        DigitSpanAttemptsText.text = "Attempts: " + PlayerPrefs.GetInt("DigitSpanAttempts", DigitSpanAttempts).ToString();
        DigitSpanBestText.text = "Best Level: " + PlayerPrefs.GetInt("Digit1BestLevel", 0).ToString();

        SpatialSpanAttemptsText.text = "Attempts: " + PlayerPrefs.GetInt("SpatialSpanAttempts", DigitSpanAttempts).ToString();
        SpatialSpanBestText.text = "Best Level: " + PlayerPrefs.GetInt("Spatial1BestLevel", 0).ToString();
    }

}
