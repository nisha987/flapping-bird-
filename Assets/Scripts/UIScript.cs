using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

    public GameObject panel;
    CanvasGroup settings;
    static bool paused;
    int score;
    [SerializeField] Text scoreTxt;

    public static bool isPaused()
    {
        return paused;
    }


    public void pauseGame()
    {
        Time.timeScale = 0;
        paused = false;
    }


    public void unpauseGame()
    {
        Time.timeScale = 1;
        paused =true;
    }

    public void appear()
    {
        pauseGame();
        settings.alpha = 1;
        settings.blocksRaycasts = true;

    }

    public void disAppear()
    {
        pauseGame();
        settings.alpha = 0;
        settings.blocksRaycasts =false;

    }


    void Start () {

        if(panel!=null)
        {
            settings = panel.GetComponent<CanvasGroup>();
        }
        if(settings!=null)
        {
            appear();
        }
	
	}
	
    
    void Update () {

        score = Mathf.FloorToInt(Time.timeSinceLevelLoad);
        scoreTxt.text = "" + score;
	
	}

    public void Startgame()
    {
        SceneManager.LoadScene("miniGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    } 
}
