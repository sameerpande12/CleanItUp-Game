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
    
    //private bool isPaused = false;
    
    // Start is called before the first frame update
    void Start()
    {
        pauseButton.onClick.AddListener(pauseGame);
        resumeButton.onClick.AddListener(resumeGame);
        nextLevelButton.onClick.AddListener(nextLevel);
        pauseMenuUI.SetActive(false);
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
       // isPaused = false;
        pauseMenuUI.SetActive(false);

    }
    void nextLevel()
    { string sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "Level1")
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
        else if(sceneName == "Level2")
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
        else if (sceneName == "Level3")
        {
            SceneManager.LoadScene("Level4", LoadSceneMode.Single);
        }
        else if (sceneName == "Level4")
        {
            SceneManager.LoadScene("Level5", LoadSceneMode.Single);
        }
        else if (sceneName == "Level5")
        {
            SceneManager.LoadScene("LevelSelector", LoadSceneMode.Single);
        }
    }

    void previousLevel() {
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "Level1")
        {
            SceneManager.LoadScene("LevelSelector", LoadSceneMode.Single);
        }
        else if (sceneName == "Level2")
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
        else if (sceneName == "Level3")
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
        else if (sceneName == "Level4")
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
        else if (sceneName == "Level5")
        {
            SceneManager.LoadScene("Level4", LoadSceneMode.Single);
        }
    }
    
    
}
