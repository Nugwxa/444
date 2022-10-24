using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpatialSpanControl : MonoBehaviour
{
    bool GameIsOver;
    bool GameC;

    //Level control
    public Text LevelText;
    public Text BestLevelText;
    public int GLevel;

    public int SpatialSpanAttempts;


    //Level 001
    public GameObject Level_1;
    public GameObject Level_1_P1;
    public GameObject Level_1_P2;
    public GameObject Level_1_P3;
    public GameObject Level_1_P4;
    public GameObject Level_1_panel;
    
    //Level 002
    public GameObject Level_2;
    public GameObject Level_2_P1;
    public GameObject Level_2_P2;
    public GameObject Level_2_P3;
    public GameObject Level_2_P4;
    public GameObject Level_2_panel;

    //Level 003
    public GameObject Level_3;
    public GameObject Level_3_P1;
    public GameObject Level_3_P2;
    public GameObject Level_3_P3;
    public GameObject Level_3_P4;
    public GameObject Level_3_panel;

    //Level 004
    public GameObject Level_4;
    public GameObject Level_4_P1;
    public GameObject Level_4_P2;
    public GameObject Level_4_P3;
    public GameObject Level_4_P4;
    public GameObject Level_4_panel;

    //Level 005
    public GameObject Level_5;
    public GameObject Level_5_P1;
    public GameObject Level_5_P2;
    public GameObject Level_5_P3;
    public GameObject Level_5_P4;
    public GameObject Level_5_panel;

    //Level 006
    public GameObject Level_6;
    public GameObject Level_6_P1;
    public GameObject Level_6_P2;
    public GameObject Level_6_P3;
    public GameObject Level_6_P4;
    public GameObject Level_6_panel;

    //Level 007
    public GameObject Level_7;
    public GameObject Level_7_P1;
    public GameObject Level_7_P2;
    public GameObject Level_7_P3;
    public GameObject Level_7_P4;
    public GameObject Level_7_panel;

    //Level 008
    public GameObject Level_8;
    public GameObject Level_8_P1;
    public GameObject Level_8_P2;
    public GameObject Level_8_P3;
    public GameObject Level_8_P4;
    public GameObject Level_8_panel;

    //Level 009
    public GameObject Level_9;
    public GameObject Level_9_P1;
    public GameObject Level_9_P2;
    public GameObject Level_9_P3;
    public GameObject Level_9_P4;
    public GameObject Level_9_panel;

    //Level 010
    public GameObject Level_10;
    public GameObject Level_10_P1;
    public GameObject Level_10_P2;
    public GameObject Level_10_P3;
    public GameObject Level_10_P4;
    public GameObject Level_10_panel;

    //Level 011
    public GameObject Level_11;
    public GameObject Level_11_P1;
    public GameObject Level_11_P2;
    public GameObject Level_11_P3;
    public GameObject Level_11_P4;
    public GameObject Level_11_P5;
    public GameObject Level_11_panel;

    //Level 012
    public GameObject Level_12;
    public GameObject Level_12_P1;
    public GameObject Level_12_P2;
    public GameObject Level_12_P3;
    public GameObject Level_12_P4;
    public GameObject Level_12_P5;
    public GameObject Level_12_panel;

    //Level 013
    public GameObject Level_13;
    public GameObject Level_13_P1;
    public GameObject Level_13_P2;
    public GameObject Level_13_P3;
    public GameObject Level_13_P4;
    public GameObject Level_13_P5;
    public GameObject Level_13_P6;
    public GameObject Level_13_panel;

    //Level 014
    public GameObject Level_14;
    public GameObject Level_14_P1;
    public GameObject Level_14_P2;
    public GameObject Level_14_P3;
    public GameObject Level_14_P4;
    public GameObject Level_14_P5;
    public GameObject Level_14_P6;
    public GameObject Level_14_panel;

    //Level 015
    public GameObject Level_15;
    public GameObject Level_15_P1;
    public GameObject Level_15_P2;
    public GameObject Level_15_P3;
    public GameObject Level_15_P4;
    public GameObject Level_15_P5;
    public GameObject Level_15_P6;
    public GameObject Level_15_panel;

    //SFX
    public AudioSource audioSource;
    public AudioClip FeedbackSound;
    public float volume = 3.5f;

    //UI 
    public GameObject GameOverUI;
    public GameObject GameCompleteUI;
    public GameObject MaxAttemptsUI;


    // Start is called before the first frame update
    void Start()
    {
        GameIsOver = false;
        GameC = false;

        GLevel = 0;
        LevelText.text = "Level: " + GLevel.ToString();
        BestLevelText.text = "Best Level: " + PlayerPrefs.GetInt("Spatial1BestLevel", 0).ToString();

        SpatialSpanAttempts = PlayerPrefs.GetInt("SpatialSpanAttempts");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsOver == true)
        {
            if (Input.GetKey(KeyCode.P))
            {
                if (SpatialSpanAttempts>14)
                {
                    MaxAttemptsUI.SetActive(true);
                    SceneManager.LoadSceneAsync("Menu");
                }
                else
                {
                    SpatialSpanAttempts = SpatialSpanAttempts + 1;
                    PlayerPrefs.SetInt("SpatialSpanAttempts", SpatialSpanAttempts);
                    SceneManager.LoadScene("Game_2_SpatialSpan");
                }
                
            }
        }


        if (GameC == true)
        {
            if (Input.GetKey(KeyCode.P))
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }

    public void UpdateScore()
    {
        GLevel = GLevel + 1;
        LevelText.text = GLevel.ToString();

        if (GLevel > PlayerPrefs.GetInt("Spatial1BestLevel", 0))
        {
            PlayerPrefs.SetInt("Spatial1BestLevel", GLevel);
            LevelText.text = "Level: " + GLevel.ToString();
            BestLevelText.text = "Best level: " + GLevel.ToString();
        }


    }


    public void PlayFeedbackSound()
    {
        audioSource.PlayOneShot(FeedbackSound);
    }

    public void WrongButton()
    {
        GameOverUI.SetActive(true);
        GameIsOver = true;

    }

    public void GameComplete()
    {
        GameC = true;
    }

    //Level 1 starts
    public void StartGame()
    {
        StartCoroutine(StartLevel1());
    }

    IEnumerator StartLevel1()
    {
        yield return new WaitForSeconds(0.4f);
        Level_1.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_1_P1.SetActive(false);
        Level_1_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_1_P2.SetActive(false);
        Level_1_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_1_P3.SetActive(false);
        Level_1_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_1_P4.SetActive(false);
        Level_1_panel.SetActive(true);
        yield return null;
    }

    public void Level1Final()
    {
        Level_1.SetActive(false);
        StartCoroutine(StartLevel2());
    }

    //Level 2 Starts
    IEnumerator StartLevel2()
    {
        yield return new WaitForSeconds(0.7f);
        Level_2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_2_P1.SetActive(false);
        Level_2_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_2_P2.SetActive(false);
        Level_2_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_2_P3.SetActive(false);
        Level_2_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_2_P4.SetActive(false);
        Level_2_panel.SetActive(true);
        yield return null;
    }

    public void Level2Final()
    {
        Level_2.SetActive(false);
        StartCoroutine(StartLevel3());
    }

    //Level 3 Starts
    IEnumerator StartLevel3()
    {
        yield return new WaitForSeconds(0.7f);
        Level_3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_3_P1.SetActive(false);
        Level_3_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_3_P2.SetActive(false);
        Level_3_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_3_P3.SetActive(false);
        Level_3_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_3_P4.SetActive(false);
        Level_3_panel.SetActive(true);
        yield return null;
    }

    public void Level3Final()
    {
        Level_3.SetActive(false);
        StartCoroutine(StartLevel4());
    }


    //Level 4 Starts
    IEnumerator StartLevel4()
    {
        yield return new WaitForSeconds(0.7f);
        Level_4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_4_P1.SetActive(false);
        Level_4_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_4_P2.SetActive(false);
        Level_4_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_4_P3.SetActive(false);
        Level_4_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_4_P4.SetActive(false);
        Level_4_panel.SetActive(true);
        yield return null;
    }

    public void Level4Final()
    {
        Level_4.SetActive(false);
        StartCoroutine(StartLevel5());
    }

    //Level 5 Starts
    IEnumerator StartLevel5()
    {
        yield return new WaitForSeconds(0.7f);
        Level_5.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_5_P1.SetActive(false);
        Level_5_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_5_P2.SetActive(false);
        Level_5_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_5_P3.SetActive(false);
        Level_5_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_5_P4.SetActive(false);
        Level_5_panel.SetActive(true);
        yield return null;
    }

    public void Level5Final()
    {
        Level_5.SetActive(false);
        StartCoroutine(StartLevel6());
    }

    //Level 6 Starts
    IEnumerator StartLevel6()
    {
        yield return new WaitForSeconds(0.7f);
        Level_6.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_6_P1.SetActive(false);
        Level_6_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_6_P2.SetActive(false);
        Level_6_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_6_P3.SetActive(false);
        Level_6_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_6_P4.SetActive(false);
        Level_6_panel.SetActive(true);
        yield return null;
    }

    public void Level6Final()
    {
        Level_6.SetActive(false);
        StartCoroutine(StartLevel7());
    }

    //Level 7 Starts
    IEnumerator StartLevel7()
    {
        yield return new WaitForSeconds(0.7f);
        Level_7.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_7_P1.SetActive(false);
        Level_7_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_7_P2.SetActive(false);
        Level_7_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_7_P3.SetActive(false);
        Level_7_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_7_P4.SetActive(false);
        Level_7_panel.SetActive(true);
        yield return null;
    }

    public void Level7Final()
    {
        Level_7.SetActive(false);
        StartCoroutine(StartLevel8());
    }

    //Level 8 Starts
    IEnumerator StartLevel8()
    {
        yield return new WaitForSeconds(0.7f);
        Level_8.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_8_P1.SetActive(false);
        Level_8_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_8_P2.SetActive(false);
        Level_8_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_8_P3.SetActive(false);
        Level_8_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_8_P4.SetActive(false);
        Level_8_panel.SetActive(true);
        yield return null;
    }

    public void Level8Final()
    {
        Level_8.SetActive(false);
        StartCoroutine(StartLevel9());
    }

    //Level 9 Starts
    IEnumerator StartLevel9()
    {
        yield return new WaitForSeconds(0.7f);
        Level_9.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_9_P1.SetActive(false);
        Level_9_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_9_P2.SetActive(false);
        Level_9_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_9_P3.SetActive(false);
        Level_9_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_9_P4.SetActive(false);
        Level_9_panel.SetActive(true);
        yield return null;
    }

    public void Level9Final()
    {
        Level_9.SetActive(false);
        StartCoroutine(StartLevel10());
    }
    //Level 10 Starts
    IEnumerator StartLevel10()
    {
        yield return new WaitForSeconds(0.7f);
        Level_10.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_10_P1.SetActive(false);
        Level_10_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_10_P2.SetActive(false);
        Level_10_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_10_P3.SetActive(false);
        Level_10_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_10_P4.SetActive(false);
        Level_10_panel.SetActive(true);
        yield return null;
    }

    public void Level10Final()
    {
        Level_10.SetActive(false);
        StartCoroutine(StartLevel11());
    }

    //Level 11 Starts
    IEnumerator StartLevel11()
    {
        yield return new WaitForSeconds(0.7f);
        Level_11.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_11_P1.SetActive(false);
        Level_11_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_11_P2.SetActive(false);
        Level_11_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_11_P3.SetActive(false);
        Level_11_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_11_P4.SetActive(false);
        Level_11_P5.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_11_P5.SetActive(false);
        Level_11_panel.SetActive(true);
        yield return null;
    }

    public void Level11Final()
    {
        Level_11.SetActive(false);
        StartCoroutine(StartLevel12());
    }

    //Level 12 Starts
    IEnumerator StartLevel12()
    {
        yield return new WaitForSeconds(0.7f);
        Level_12.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_12_P1.SetActive(false);
        Level_12_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_12_P2.SetActive(false);
        Level_12_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_12_P3.SetActive(false);
        Level_12_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_12_P4.SetActive(false);
        Level_12_P5.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_12_P5.SetActive(false);
        Level_12_panel.SetActive(true);
        yield return null;
    }

    public void Level12Final()
    {
        Level_12.SetActive(false);
        StartCoroutine(StartLevel13());
    }

    //Level 13 Starts
    IEnumerator StartLevel13()
    {
        yield return new WaitForSeconds(0.7f);
        Level_13.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_13_P1.SetActive(false);
        Level_13_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_13_P2.SetActive(false);
        Level_13_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_13_P3.SetActive(false);
        Level_13_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_13_P4.SetActive(false);
        Level_13_P5.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_13_P5.SetActive(false);
        Level_13_P6.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_13_P6.SetActive(false);
        Level_13_panel.SetActive(true);
        yield return null;
    }

    public void Level13Final()
    {
        Level_13.SetActive(false);
        StartCoroutine(StartLevel14());
    }

    //Level 14 Starts
    IEnumerator StartLevel14()
    {
        yield return new WaitForSeconds(0.7f);
        Level_14.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_14_P1.SetActive(false);
        Level_14_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_14_P2.SetActive(false);
        Level_14_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_14_P3.SetActive(false);
        Level_14_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_14_P4.SetActive(false);
        Level_14_P5.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_14_P5.SetActive(false);
        Level_14_P6.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_14_P6.SetActive(false);
        Level_14_panel.SetActive(true);
        yield return null;
    }

    public void Level14Final()
    {
        Level_14.SetActive(false);
        StartCoroutine(StartLevel15());
    }

    //Level 15 Starts
    IEnumerator StartLevel15()
    {
        yield return new WaitForSeconds(0.7f);
        Level_15.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_15_P1.SetActive(false);
        Level_15_P2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_15_P2.SetActive(false);
        Level_15_P3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_15_P3.SetActive(false);
        Level_15_P4.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_15_P4.SetActive(false);
        Level_15_P5.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_15_P5.SetActive(false);
        Level_15_P6.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        Level_15_P6.SetActive(false);
        Level_15_panel.SetActive(true);
        yield return null;
    }

    public void Level15Final()
    {
        Level_13.SetActive(false);
        GameCompleteUI.SetActive(true);
        GameComplete();
    }
}
