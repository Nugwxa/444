using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    public string LoadLevel;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadPlay()); //Once the game loads, wait 5 seconds then load the next level.
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LoadPlay()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadSceneAsync(LoadLevel);
        yield return null;
    }
}
