using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;

    public void GoToPause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GoToRetry()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
        GameManager.isLive = false;
        GameManager.isFinish = false;
        GameManager.isHit = false;
        GameManager.score = 0;
        GameManager.health = 3;
        
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Start");
        GameManager.level = 0;
        GameManager.isLive = false;
        GameManager.isFinish = false;
        GameManager.isHit = false;
        GameManager.score = 0;
        GameManager.health = 3;
        Time.timeScale = 1f;
        Destroy(GameManager.bgm.gameObject);

    }

    public void GoToResume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
        
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
