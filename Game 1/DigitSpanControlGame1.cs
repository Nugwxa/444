using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DigitSpanControlGame1 : MonoBehaviour
{
    public GameObject GameOverUI; //GameOver UI
    public GameObject GameCompleteUI; //GameOver UI
    public GameObject EarSymbol; //Ear symbol

    //attempts
    public int DigitSpanAttempts;
    public GameObject MaxAttemptsUI;

    //Levels
    public GameObject Level001;
    public GameObject Level002;
    public GameObject Level003;
    public GameObject Level004;
    public GameObject Level005;
    public GameObject Level006;
    public GameObject Level007;
    public GameObject Level008;
    public GameObject Level009;
    public GameObject Level010;
    public GameObject Level011;
    public GameObject Level012;
    public GameObject Level013;
    public GameObject Level014;
    public GameObject Level015;


    //Play Colors
    public AudioSource audioSource;

    public AudioClip FeedbackSound;

    public AudioClip Level_1_Clip;
    public AudioClip Level_2_Clip;
    public AudioClip Level_3_Clip;
    public AudioClip Level_4_Clip;
    public AudioClip Level_5_Clip;
    public AudioClip Level_6_Clip;
    public AudioClip Level_7_Clip;
    public AudioClip Level_8_Clip;
    public AudioClip Level_9_Clip;
    public AudioClip Level_10_Clip;
    public AudioClip Level_11_Clip;
    public AudioClip Level_12_Clip;
    public AudioClip Level_13_Clip;
    public AudioClip Level_14_Clip;
    public AudioClip Level_15_Clip;


    public float volume = 3.5f;
    bool GameIsOver;
    bool GameC;



    // Start is called before the first frame update
    void Start()
    {
        GameIsOver = false;
        GameC = false;

        DigitSpanAttempts = PlayerPrefs.GetInt("DigitSpanAttempts");
    }

    // Update is called once per frame
    void Update()
    {

        if (GameIsOver == true)
        {
            if (GameIsOver == true) 
            {
            //If the user presses "P" whlile the game is over and they have reached 5 attempts, stop them from playing, else, restart the game and add to their attempts 
                if (Input.GetKey(KeyCode.P)) 
                {
                    if (DigitSpanAttempts > 4)
                    {
                        MaxAttemptsUI.SetActive(true);
                        SceneManager.LoadSceneAsync("Menu");
                    }
                    else
                    {
                        DigitSpanAttempts = DigitSpanAttempts + 1;
                        PlayerPrefs.SetInt("DigitSpanAttempts", DigitSpanAttempts);
                        SceneManager.LoadScene("DigitSpan");
                    }

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



    //Level 1
    public void StartGame()
    {
        audioSource.PlayOneShot(Level_1_Clip, volume);
        StartCoroutine(ShowLevel1Button());
    }

    IEnumerator ShowLevel1Button()
    {
        yield return new WaitForSeconds(3);
        Level001.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void LevelOneFinal()
    {
        Level001.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_2_Clip, volume);
        StartCoroutine(ShowLevel2Button());
    }
    //Level 1 Ends

    //Level 2 Begins
    IEnumerator ShowLevel2Button()
    {
        yield return new WaitForSeconds(4);
        Level002.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void LevelTwoFinal()
    {
        Level002.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_3_Clip, volume);
        StartCoroutine(ShowLevel3Button());
    }
    //Level 2 Ends

    //Level 3 Begins
    IEnumerator ShowLevel3Button()
    {
        yield return new WaitForSeconds(3);
        Level003.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level3Final()
    {
        Level003.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_4_Clip, volume);
        StartCoroutine(ShowLevel4Button());
    }
    //Level 3 Ends

    //Level 4 Begins
    IEnumerator ShowLevel4Button()
    {
        yield return new WaitForSeconds(3);
        Level004.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level4Final()
    {
        Level004.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_5_Clip, volume);
        StartCoroutine(ShowLevel5Button());
    }
    //Level 4 Ends

    //Level 5 Begins
    IEnumerator ShowLevel5Button()
    {
        yield return new WaitForSeconds(3);
        Level005.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level5Final()
    {
        Level005.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_6_Clip, volume);
        StartCoroutine(ShowLevel6Button());
    }
    //Level 5 Ends

    //Level 6 Begins
    IEnumerator ShowLevel6Button()
    {
        yield return new WaitForSeconds(3);
        Level006.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level6Final()
    {
        Level006.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_7_Clip, volume);
        StartCoroutine(ShowLevel7Button());

    }
    //Level 6 Ends

    //Level 7 Begins
    IEnumerator ShowLevel7Button()
    {
        yield return new WaitForSeconds(3);
        Level007.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level7Final()
    {
        Level007.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_8_Clip, volume);
        StartCoroutine(ShowLevel8Button());

    }
    //Level 7 Ends

    //Level 8 Begins
    IEnumerator ShowLevel8Button()
    {
        yield return new WaitForSeconds(3);
        Level008.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level8Final()
    {
        Level008.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_9_Clip, volume);
        StartCoroutine(ShowLevel9Button());

    }
    //Level 8 Ends

    //Level 9 Begins
    IEnumerator ShowLevel9Button()
    {
        yield return new WaitForSeconds(3);
        Level009.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level9Final()
    {
        Level009.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_10_Clip, volume);
        StartCoroutine(ShowLevel10Button());

    }
    //Level 9 Ends

    //Level 10 Begins
    IEnumerator ShowLevel10Button()
    {
        yield return new WaitForSeconds(3);
        Level010.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level10Final()
    {
        Level010.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_11_Clip, volume);
        StartCoroutine(ShowLevel11Button());

    }
    //Level 10 Ends

    //Level 11 Begins
    IEnumerator ShowLevel11Button()
    {
        yield return new WaitForSeconds(3);
        Level011.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level11Final()
    {
        Level011.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_12_Clip, volume);
        StartCoroutine(ShowLevel12Button());

    }
    //Level 11 Ends

    //Level 12 Begins
    IEnumerator ShowLevel12Button()
    {
        yield return new WaitForSeconds(3);
        Level012.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level12Final()
    {
        Level012.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_13_Clip, volume);
        StartCoroutine(ShowLevel13Button());

    }
    //Level 12 Ends

    //Level 13 Begins
    IEnumerator ShowLevel13Button()
    {
        yield return new WaitForSeconds(3);
        Level013.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level13Final()
    {
        Level013.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_14_Clip, volume);
        StartCoroutine(ShowLevel14Button());
    }
    //Level 13 Ends

    //Level 14 Begins
    IEnumerator ShowLevel14Button()
    {
        yield return new WaitForSeconds(3);
        Level014.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level14Final()
    {
        Level014.SetActive(false);
        EarSymbol.SetActive(true);
        audioSource.PlayOneShot(Level_15_Clip, volume);
        StartCoroutine(ShowLevel15Button());
    }
    //Level 14 Ends

    //Level 15 Begins
    IEnumerator ShowLevel15Button()
    {
        yield return new WaitForSeconds(3);
        Level015.SetActive(true);
        EarSymbol.SetActive(false);

        yield return null;
    }

    public void Level15Final()
    {
        Level015.SetActive(false);
        GameCompleteUI.SetActive(true);
        GameComplete();

    }
}
