using UnityEngine;
using UnityEngine.UI;

public class DigitSpanScore : MonoBehaviour
{
    public Text LevelText; 
    public Text BestLevelText; //Highest Level
    public int GLevel; //Cleared Levels

    void Start() //Called at the start of the application
    {
        GLevel = 0;
        LevelText.text = "Level: " + GLevel.ToString(); //Level text displays th current level
        BestLevelText.text = "Best Level: " + PlayerPrefs.GetInt("Digit1BestLevel", 1).ToString(); 
    }

    public void UpdateScore() //Upadtes the users level
    {
        GLevel = GLevel + 1;
        LevelText.text = GLevel.ToString(); //Update level text

        //if the user's current level is higher than best level, update their best level to their current level
        if (GLevel > PlayerPrefs.GetInt("Digit1BestLevel", 0)) 
        {
            PlayerPrefs.SetInt("Digit1BestLevel", GLevel);
            BestLevelText.text = GLevel.ToString();
        }

        
    }
}
