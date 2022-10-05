using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        MenuManager.instance.SaveScore();
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        MenuManager.instance.LoadScore();
        MenuManager.instance.score = 0;
        
    }  
    public void QuitGame()
    {
        
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
   Application.Quit();
#endif
        

    }    
    public void ResetScore()
    {
        MenuManager.instance.highScore = 0;
        MenuManager.instance.playerHighScoreName = null;
        MenuManager.instance.SaveScore();
    }
}
