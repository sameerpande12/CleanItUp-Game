using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class onOffScript : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private Button previousLevelButton;
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private Text panelText;
    [SerializeField] private Text ScoreText;
    private bool  isGameOver;
    //private bool isPaused = false;
    
    // Start is called before the first frame update
    void Start()
    {
        pauseButton.onClick.AddListener(pauseGame);
        resumeButton.onClick.AddListener(resumeGame);
        nextLevelButton.onClick.AddListener(nextLevel);
        previousLevelButton.onClick.AddListener(previousLevel);
        pauseMenuUI.SetActive(false);
        panelText.text = "Paused";
        isGameOver = false;
    }

    void pauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
     //   isPaused = true;
    }

    void resumeGame()
    {
        Time.timeScale = 1f;
        if (isGameOver)
        {
            pauseMenuUI.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
            
        }
        pauseMenuUI.SetActive(false);

    }
    void nextLevel()
    { string sceneName = SceneManager.GetActiveScene().name;
        
        if(sceneName == "Level1")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
        else if(sceneName == "Level2")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
        else if (sceneName == "Level3")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level4", LoadSceneMode.Single);
        }
        else if (sceneName == "Level4")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level5", LoadSceneMode.Single);
        }
        else if (sceneName == "Level5")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("LevelSelector", LoadSceneMode.Single);
        }
    }

    void previousLevel() {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "Level1")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("LevelSelector", LoadSceneMode.Single);
        }
        else if (sceneName == "Level2")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
        else if (sceneName == "Level3")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
        else if (sceneName == "Level4")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
        else if (sceneName == "Level5")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level4", LoadSceneMode.Single);
        }
    }

    public void gameOver()
    {
        panelText.text = ScoreText.text;
        isGameOver = true;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }
    
    
}
